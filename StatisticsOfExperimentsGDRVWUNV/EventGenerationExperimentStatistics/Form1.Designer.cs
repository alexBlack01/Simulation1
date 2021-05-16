
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelChiSquare = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumberOfExperiments = new System.Windows.Forms.TextBox();
            this.buttonСalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.probabilityDiagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.probTrue = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel1.Controls.Add(this.labelError);
            this.splitContainer1.Panel1.Controls.Add(this.probTrue);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.labelChiSquare);
            this.splitContainer1.Panel1.Controls.Add(this.labelVariance);
            this.splitContainer1.Panel1.Controls.Add(this.labelAverage);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNumberOfExperiments);
            this.splitContainer1.Panel1.Controls.Add(this.buttonСalculate);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.probabilityDiagram);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "Геометрическое распределение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Location = new System.Drawing.Point(133, 359);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(24, 17);
            this.labelVariance.TabIndex = 17;
            this.labelVariance.Text = "24";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(133, 333);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(24, 17);
            this.labelAverage.TabIndex = 16;
            this.labelAverage.Text = "24";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Дисперсия: ";
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
            // textBoxNumberOfExperiments
            // 
            this.textBoxNumberOfExperiments.Location = new System.Drawing.Point(181, 172);
            this.textBoxNumberOfExperiments.Name = "textBoxNumberOfExperiments";
            this.textBoxNumberOfExperiments.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberOfExperiments.TabIndex = 12;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Вероятность успеха:";
            // 
            // probTrue
            // 
            this.probTrue.Location = new System.Drawing.Point(181, 104);
            this.probTrue.Name = "probTrue";
            this.probTrue.Size = new System.Drawing.Size(100, 22);
            this.probTrue.TabIndex = 21;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 254);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 22;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart probabilityDiagram;
        private System.Windows.Forms.TextBox textBoxNumberOfExperiments;
        private System.Windows.Forms.Button buttonСalculate;
        private System.Windows.Forms.Label labelChiSquare;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox probTrue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelError;
    }
}

