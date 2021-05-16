
namespace EventGenerationExperimentStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxNumberOfExperiments = new System.Windows.Forms.TextBox();
            this.textBoxProbability5 = new System.Windows.Forms.TextBox();
            this.textBoxProbability4 = new System.Windows.Forms.TextBox();
            this.textBoxProbability3 = new System.Windows.Forms.TextBox();
            this.textBoxProbability2 = new System.Windows.Forms.TextBox();
            this.textBoxProbability1 = new System.Windows.Forms.TextBox();
            this.buttonСalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.probabilityDiagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.labelChiSquare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelChiSquare);
            this.splitContainer1.Panel1.Controls.Add(this.labelVariance);
            this.splitContainer1.Panel1.Controls.Add(this.labelAverage);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNumberOfExperiments);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProbability5);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProbability4);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProbability3);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProbability2);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxProbability1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonСalculate);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.probabilityDiagram);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxNumberOfExperiments
            // 
            this.textBoxNumberOfExperiments.Location = new System.Drawing.Point(181, 172);
            this.textBoxNumberOfExperiments.Name = "textBoxNumberOfExperiments";
            this.textBoxNumberOfExperiments.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberOfExperiments.TabIndex = 12;
            // 
            // textBoxProbability5
            // 
            this.textBoxProbability5.Location = new System.Drawing.Point(180, 119);
            this.textBoxProbability5.Name = "textBoxProbability5";
            this.textBoxProbability5.ReadOnly = true;
            this.textBoxProbability5.Size = new System.Drawing.Size(100, 22);
            this.textBoxProbability5.TabIndex = 11;
            // 
            // textBoxProbability4
            // 
            this.textBoxProbability4.Location = new System.Drawing.Point(180, 91);
            this.textBoxProbability4.Name = "textBoxProbability4";
            this.textBoxProbability4.Size = new System.Drawing.Size(100, 22);
            this.textBoxProbability4.TabIndex = 10;
            this.textBoxProbability4.TextChanged += new System.EventHandler(this.textBoxProbability4_TextChanged);
            // 
            // textBoxProbability3
            // 
            this.textBoxProbability3.Location = new System.Drawing.Point(180, 63);
            this.textBoxProbability3.Name = "textBoxProbability3";
            this.textBoxProbability3.Size = new System.Drawing.Size(100, 22);
            this.textBoxProbability3.TabIndex = 9;
            this.textBoxProbability3.TextChanged += new System.EventHandler(this.textBoxProbability3_TextChanged);
            // 
            // textBoxProbability2
            // 
            this.textBoxProbability2.Location = new System.Drawing.Point(180, 34);
            this.textBoxProbability2.Name = "textBoxProbability2";
            this.textBoxProbability2.Size = new System.Drawing.Size(100, 22);
            this.textBoxProbability2.TabIndex = 8;
            this.textBoxProbability2.TextChanged += new System.EventHandler(this.textBoxProbability2_TextChanged);
            // 
            // textBoxProbability1
            // 
            this.textBoxProbability1.Location = new System.Drawing.Point(180, 6);
            this.textBoxProbability1.Name = "textBoxProbability1";
            this.textBoxProbability1.Size = new System.Drawing.Size(100, 22);
            this.textBoxProbability1.TabIndex = 7;
            this.textBoxProbability1.TextChanged += new System.EventHandler(this.textBoxProbability1_TextChanged);
            // 
            // buttonСalculate
            // 
            this.buttonСalculate.Location = new System.Drawing.Point(80, 200);
            this.buttonСalculate.Name = "buttonСalculate";
            this.buttonСalculate.Size = new System.Drawing.Size(115, 39);
            this.buttonСalculate.TabIndex = 6;
            this.buttonСalculate.Text = "Рассчитать";
            this.buttonСalculate.UseVisualStyleBackColor = true;
            this.buttonСalculate.Click += new System.EventHandler(this.buttonСalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кол-во экспериментов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вероятность №5:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вероятность №4:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вероятность №3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вероятность №2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вероятность №1:";
            // 
            // probabilityDiagram
            // 
            chartArea1.AxisX.Maximum = 6D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.probabilityDiagram.ChartAreas.Add(chartArea1);
            this.probabilityDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.probabilityDiagram.Location = new System.Drawing.Point(0, 0);
            this.probabilityDiagram.Name = "probabilityDiagram";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.probabilityDiagram.Series.Add(series1);
            this.probabilityDiagram.Size = new System.Drawing.Size(513, 450);
            this.probabilityDiagram.TabIndex = 0;
            this.probabilityDiagram.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Мат. ожидание:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Дисперсия: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Хи-квадрат: ";
            // 
            // labelExpectedValue
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(133, 333);
            this.labelAverage.Name = "labelExpectedValue";
            this.labelAverage.Size = new System.Drawing.Size(24, 17);
            this.labelAverage.TabIndex = 16;
            this.labelAverage.Text = "24";
            // 
            // labelDispersion
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Location = new System.Drawing.Point(133, 359);
            this.labelVariance.Name = "labelDispersion";
            this.labelVariance.Size = new System.Drawing.Size(24, 17);
            this.labelVariance.TabIndex = 17;
            this.labelVariance.Text = "24";
            // 
            // labelChiSquare
            // 
            this.labelChiSquare.AutoSize = true;
            this.labelChiSquare.Location = new System.Drawing.Point(133, 387);
            this.labelChiSquare.Name = "labelChiSquare";
            this.labelChiSquare.Size = new System.Drawing.Size(24, 17);
            this.labelChiSquare.TabIndex = 18;
            this.labelChiSquare.Text = "24";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDiagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart probabilityDiagram;
        private System.Windows.Forms.TextBox textBoxNumberOfExperiments;
        private System.Windows.Forms.TextBox textBoxProbability5;
        private System.Windows.Forms.TextBox textBoxProbability4;
        private System.Windows.Forms.TextBox textBoxProbability3;
        private System.Windows.Forms.TextBox textBoxProbability2;
        private System.Windows.Forms.TextBox textBoxProbability1;
        private System.Windows.Forms.Button buttonСalculate;
        private System.Windows.Forms.Label labelChiSquare;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}

