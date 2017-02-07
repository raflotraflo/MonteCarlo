using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private int i = 0;
        private Thread _mainThread;

        private int _radius = 1000;
        private List<double> _valueOfPiList = new List<double>();

        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();

            textBoxCoreCount.Text = Environment.ProcessorCount.ToString();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            _mainThread = new Thread(Calculate);
            _mainThread.Start();
        }


        private void Calculate()
        {
            int monteCarloCount;

            bool canParse = int.TryParse(textBoxMonteCarloCount.Text, out monteCarloCount);

            if (!canParse)
            {
                this.SetText("Zła wprowadzona liczba");
                return;
            }

            this.SetText("Obliczam ...");

            List<Thread> threads = new List<Thread>();
            _valueOfPiList.Clear();

            int iloscRdzeni = Environment.ProcessorCount;
            

            for (int i = 1; i <= iloscRdzeni; i++)
            {
                Thread thread = new Thread(() => MonteCarlo(1000));
                thread.Start();
                threads.Add(thread);
            }

            WaitAll(threads);

            double sum = 0;

            _valueOfPiList.ForEach(x =>
            {
                sum += x;
            });

            double PI = sum/iloscRdzeni;



            this.SetText("Stop");
        }

        private void MonteCarlo(int randomCount)
        {
            Thread.Sleep(500);

            int pointsInCircle = 0;
            //int pointsOutOfCircle = 0;
            Random gen = new Random(); //utowrzenie generatora liczb losowych

            for (int j = 0; j < randomCount; j++)
            {
                int x = gen.Next(0, _radius); // losowanie położenia na osi x
                int y = gen.Next(0, _radius); // na osi y 
                //liczby są losowane tylko w jednej ćwiartce kwadratu, dlatego są losowane od 0 do R, a kwadrat ma bok 2R
                //promień koło _radius = R 

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

        private void SetText(string text)
        {
            if (this.textBoxTime.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxTime.Text = text;
            }
        }
    }
}
