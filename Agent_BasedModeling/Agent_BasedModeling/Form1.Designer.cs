
namespace Agent_BasedModeling
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelIntensity2 = new System.Windows.Forms.Label();
            this.textBoxIntensity2 = new System.Windows.Forms.TextBox();
            this.textBoxIntensity1 = new System.Windows.Forms.TextBox();
            this.textBoxOperators = new System.Windows.Forms.TextBox();
            this.logs = new System.Windows.Forms.ListBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.labelIntensity1 = new System.Windows.Forms.Label();
            this.labelOperators = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.labelIntensity2);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIntensity2);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxIntensity1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxOperators);
            this.splitContainer1.Panel1.Controls.Add(this.logs);
            this.splitContainer1.Panel1.Controls.Add(this.stopButton);
            this.splitContainer1.Panel1.Controls.Add(this.startButton);
            this.splitContainer1.Panel1.Controls.Add(this.labelIntensity1);
            this.splitContainer1.Panel1.Controls.Add(this.labelOperators);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 655);
            this.splitContainer1.SplitterDistance = 446;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelIntensity2
            // 
            this.labelIntensity2.AutoSize = true;
            this.labelIntensity2.Location = new System.Drawing.Point(14, 84);
            this.labelIntensity2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIntensity2.Name = "labelIntensity2";
            this.labelIntensity2.Size = new System.Drawing.Size(134, 17);
            this.labelIntensity2.TabIndex = 30;
            this.labelIntensity2.Text = "Интенсивность №2";
            // 
            // textBoxIntensity2
            // 
            this.textBoxIntensity2.Location = new System.Drawing.Point(155, 81);
            this.textBoxIntensity2.Name = "textBoxIntensity2";
            this.textBoxIntensity2.Size = new System.Drawing.Size(100, 22);
            this.textBoxIntensity2.TabIndex = 29;
            // 
            // textBoxIntensity1
            // 
            this.textBoxIntensity1.Location = new System.Drawing.Point(155, 53);
            this.textBoxIntensity1.Name = "textBoxIntensity1";
            this.textBoxIntensity1.Size = new System.Drawing.Size(100, 22);
            this.textBoxIntensity1.TabIndex = 28;
            // 
            // textBoxOperators
            // 
            this.textBoxOperators.Location = new System.Drawing.Point(155, 25);
            this.textBoxOperators.Name = "textBoxOperators";
            this.textBoxOperators.Size = new System.Drawing.Size(100, 22);
            this.textBoxOperators.TabIndex = 27;
            // 
            // logs
            // 
            this.logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logs.FormattingEnabled = true;
            this.logs.HorizontalScrollbar = true;
            this.logs.ItemHeight = 16;
            this.logs.Location = new System.Drawing.Point(13, 158);
            this.logs.Margin = new System.Windows.Forms.Padding(4);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(419, 484);
            this.logs.TabIndex = 26;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(313, 69);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(118, 46);
            this.stopButton.TabIndex = 25;
            this.stopButton.Text = "Закончить";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(313, 13);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 46);
            this.startButton.TabIndex = 24;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // labelIntensity1
            // 
            this.labelIntensity1.AutoSize = true;
            this.labelIntensity1.Location = new System.Drawing.Point(14, 56);
            this.labelIntensity1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIntensity1.Name = "labelIntensity1";
            this.labelIntensity1.Size = new System.Drawing.Size(134, 17);
            this.labelIntensity1.TabIndex = 20;
            this.labelIntensity1.Text = "Интенсивность №1";
            // 
            // labelOperators
            // 
            this.labelOperators.AutoSize = true;
            this.labelOperators.Location = new System.Drawing.Point(14, 28);
            this.labelOperators.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperators.Name = "labelOperators";
            this.labelOperators.Size = new System.Drawing.Size(135, 17);
            this.labelOperators.TabIndex = 18;
            this.labelOperators.Text = "Кол-во операторов";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Emperic";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Actual";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(652, 649);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(13, 134);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 655);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelIntensity2;
        private System.Windows.Forms.TextBox textBoxIntensity2;
        private System.Windows.Forms.TextBox textBoxIntensity1;
        private System.Windows.Forms.TextBox textBoxOperators;
        private System.Windows.Forms.ListBox logs;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label labelIntensity1;
        private System.Windows.Forms.Label labelOperators;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelError;
    }
}

