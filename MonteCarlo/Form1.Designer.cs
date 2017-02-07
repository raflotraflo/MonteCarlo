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
            this.SuspendLayout();
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(388, 391);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(132, 45);
            this.ButtonCalculate.TabIndex = 1;
            this.ButtonCalculate.Text = "Oblicz";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(198, 218);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(158, 22);
            this.textBoxTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ilość wątków";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Czas obliczeń";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilość rdzeni";
            // 
            // textBoxCoreCount
            // 
            this.textBoxCoreCount.Location = new System.Drawing.Point(362, 43);
            this.textBoxCoreCount.Name = "textBoxCoreCount";
            this.textBoxCoreCount.ReadOnly = true;
            this.textBoxCoreCount.Size = new System.Drawing.Size(158, 22);
            this.textBoxCoreCount.TabIndex = 6;
            // 
            // textBoxMonteCarloCount
            // 
            this.textBoxMonteCarloCount.Location = new System.Drawing.Point(12, 117);
            this.textBoxMonteCarloCount.Name = "textBoxMonteCarloCount";
            this.textBoxMonteCarloCount.Size = new System.Drawing.Size(158, 22);
            this.textBoxMonteCarloCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ilość powtórzeń w metodzie Monte Carlo";
            // 
            // comboBoxThreadCount
            // 
            this.comboBoxThreadCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThreadCount.FormattingEnabled = true;
            this.comboBoxThreadCount.Location = new System.Drawing.Point(12, 43);
            this.comboBoxThreadCount.Name = "comboBoxThreadCount";
            this.comboBoxThreadCount.Size = new System.Drawing.Size(158, 24);
            this.comboBoxThreadCount.TabIndex = 0;
            this.comboBoxThreadCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxThreadCount_SelectedIndexChanged);
            // 
            // textBoxPi
            // 
            this.textBoxPi.Location = new System.Drawing.Point(12, 218);
            this.textBoxPi.Name = "textBoxPi";
            this.textBoxPi.ReadOnly = true;
            this.textBoxPi.Size = new System.Drawing.Size(158, 22);
            this.textBoxPi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wynik PI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 448);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

