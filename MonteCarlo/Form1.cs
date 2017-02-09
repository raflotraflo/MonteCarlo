using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo
{
    public partial class Form1 : Form
    {
        //private int i = 0;
        private Thread _mainThread;
        private bool _isCalculating = false;
        private object lockCalculate = new object(); 

        private int _radius = 1000;
        private List<double> _valueOfPiList = new List<double>();

        delegate void SetTimeCallback(string text);
        delegate void SetTextCallback(string text);

        int _threadsCount = 0;

        public Form1()
        {
            InitializeComponent();

            int processorCount = Environment.ProcessorCount;

            for (int i = 1; i <= processorCount; i++)
            {
                comboBoxThreadCount.Items.Add(new ComboboxItem(i));
            }
            comboBoxThreadCount.SelectedIndex = 0;

            textBoxCoreCount.Text = processorCount.ToString();
            textBoxMonteCarloCount.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (_isCalculating)
            {
                return;
            }

            _mainThread = new Thread(Calculate);
            _mainThread.Start(); 
        }

        private void Calculate()
        {
            lock (lockCalculate) 
            {
                _isCalculating = true;

                Stopwatch watch = new Stopwatch();
                watch.Start();

                int monteCarloCount;
                bool canParse = int.TryParse(textBoxMonteCarloCount.Text, out monteCarloCount);

                if (!canParse)
                {
                    this.SetText("Zła liczba");
                    return;
                }

                this.SetText("O ");

                List<Thread> threads = new List<Thread>();
                _valueOfPiList.Clear();

                int operationsPerThread = monteCarloCount / _threadsCount;

                for (int i = 1; i <= _threadsCount; i++)
                {
                    Thread thread = new Thread(() => MonteCarlo(operationsPerThread));
                    thread.Start();
                    threads.Add(thread);
                }

                WaitAll(threads);

                double sum = 0;

                _valueOfPiList.ForEach(x =>
                {
                    sum += x;
                });

                double PI = sum / _threadsCount;

                watch.Stop();
                this.SetText("PI = " + PI);
                this.SetTime(watch.Elapsed.TotalMilliseconds + " ms");

                _isCalculating = false;
            }

        }

        private void MonteCarlo(int randomCount)
        {
            int pointsInCircle = 0;
            int percent = 0;

            Random gen = new Random();

            for (int j = 0; j < randomCount; j++)
            {
                int x = gen.Next(0, _radius); 
                int y = gen.Next(0, _radius); 


                var length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));        

                if (length < (double) _radius)
                {
                    pointsInCircle++;
                }
            }

            double pi = 4* (double)((double)pointsInCircle /(double)randomCount); //oblicenie liczby PI
            _valueOfPiList.Add(pi);
        }

        static void WaitAll(IEnumerable<Thread> threads)
        {
            if (threads != null)
            {
                foreach (Thread thread in threads)
                {
                    thread.Join();
                }
            }
        }

        private void SetTime(string text)
        {
            if (this.textBoxTime.InvokeRequired)
            {
                SetTimeCallback d = new SetTimeCallback(SetTime);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxTime.Text = text;
            }
        }

        private void SetText(string text)
        {
            if (this.textBoxPi.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxPi.Text = text;
            }
        }

        private void comboBoxThreadCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            var item = (ComboboxItem) cmb.SelectedItem;
            _threadsCount = item.Value;
        }
    }
}
