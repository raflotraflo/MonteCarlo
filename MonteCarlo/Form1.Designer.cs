namespace MonteCarlo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCoreCount = new System.Windows.Forms.TextBox();
            this.textBoxMonteCarloCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxThreadCount = new System.Windows.Forms.ComboBox();
            this.textBoxPi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCalculate.Location = new System.Drawing.Point(7, 226);
            this.ButtonCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(364, 49);
            this.ButtonCalculate.TabIndex = 1;
            this.ButtonCalculate.Text = "Run";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxTime.Location = new System.Drawing.Point(252, 180);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(120, 20);
            this.textBoxTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ilość wątków";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Czas obliczeń";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(249, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilość rdzeni";
            // 
            // textBoxCoreCount
            // 
            this.textBoxCoreCount.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxCoreCount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxCoreCount.Location = new System.Drawing.Point(252, 36);
            this.textBoxCoreCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCoreCount.Name = "textBoxCoreCount";
            this.textBoxCoreCount.ReadOnly = true;
            this.textBoxCoreCount.Size = new System.Drawing.Size(120, 20);
            this.textBoxCoreCount.TabIndex = 6;
            // 
            // textBoxMonteCarloCount
            // 
            this.textBoxMonteCarloCount.Location = new System.Drawing.Point(9, 95);
            this.textBoxMonteCarloCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMonteCarloCount.Name = "textBoxMonteCarloCount";
            this.textBoxMonteCarloCount.Size = new System.Drawing.Size(120, 20);
            this.textBoxMonteCarloCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wpisz ilość iteracji w metodzie Monte Carlo";
            // 
            // comboBoxThreadCount
            // 
            this.comboBoxThreadCount.BackColor = System.Drawing.Color.White;
            this.comboBoxThreadCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxThreadCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThreadCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxThreadCount.ForeColor = System.Drawing.Color.Black;
            this.comboBoxThreadCount.FormattingEnabled = true;
            this.comboBoxThreadCount.Location = new System.Drawing.Point(7, 36);
            this.comboBoxThreadCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxThreadCount.Name = "comboBoxThreadCount";
            this.comboBoxThreadCount.Size = new System.Drawing.Size(120, 24);
            this.comboBoxThreadCount.TabIndex = 0;
            this.comboBoxThreadCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxThreadCount_SelectedIndexChanged);
            // 
            // textBoxPi
            // 
            this.textBoxPi.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPi.Location = new System.Drawing.Point(252, 136);
            this.textBoxPi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPi.Name = "textBoxPi";
            this.textBoxPi.ReadOnly = true;
            this.textBoxPi.Size = new System.Drawing.Size(120, 20);
            this.textBoxPi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wynik PI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 318);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMonteCarloCount);
            this.Controls.Add(this.textBoxCoreCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.comboBoxThreadCount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Obliczanie liczby pi metodą Monte Carlo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.ComboBox comboBoxThreadCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCoreCount;
        private System.Windows.Forms.TextBox textBoxMonteCarloCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

