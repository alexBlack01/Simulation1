
namespace ModelingSimplestFlows
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelError = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxLambda2 = new System.Windows.Forms.TextBox();
            this.textBoxLambda1 = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.tLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.lambda2 = new System.Windows.Forms.Label();
            this.lambda1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.splitContainer1.Panel1.Controls.Add(this.labelTime);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFinish);
            this.splitContainer1.Panel1.Controls.Add(this.buttonStart);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLambda2);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLambda1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxT);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxN);
            this.splitContainer1.Panel1.Controls.Add(this.tLabel);
            this.splitContainer1.Panel1.Controls.Add(this.nLabel);
            this.splitContainer1.Panel1.Controls.Add(this.lambda2);
            this.splitContainer1.Panel1.Controls.Add(this.lambda1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 538);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.SystemColors.Control;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(13, 210);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 11;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(73, 483);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(184, 31);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "Время: 0 сек.";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(174, 369);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(100, 42);
            this.buttonFinish.TabIndex = 9;
            this.buttonFinish.Text = "Закончить";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(68, 369);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 42);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxLambda2
            // 
            this.textBoxLambda2.Location = new System.Drawing.Point(58, 116);
            this.textBoxLambda2.Name = "textBoxLambda2";
            this.textBoxLambda2.Size = new System.Drawing.Size(100, 22);
            this.textBoxLambda2.TabIndex = 7;
            // 
            // textBoxLambda1
            // 
            this.textBoxLambda1.Location = new System.Drawing.Point(58, 88);
            this.textBoxLambda1.Name = "textBoxLambda1";
            this.textBoxLambda1.Size = new System.Drawing.Size(100, 22);
            this.textBoxLambda1.TabIndex = 6;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(58, 60);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 22);
            this.textBoxT.TabIndex = 5;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(58, 31);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 4;
            // 
            // tLabel
            // 
            this.tLabel.AutoSize = true;
            this.tLabel.Location = new System.Drawing.Point(35, 63);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(17, 17);
            this.tLabel.TabIndex = 3;
            this.tLabel.Text = "T";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(34, 34);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(18, 17);
            this.nLabel.TabIndex = 2;
            this.nLabel.Text = "N";
            // 
            // lambda2
            // 
            this.lambda2.AutoSize = true;
            this.lambda2.Location = new System.Drawing.Point(35, 119);
            this.lambda2.Name = "lambda2";
            this.lambda2.Size = new System.Drawing.Size(23, 17);
            this.lambda2.TabIndex = 1;
            this.lambda2.Text = "λ2";
            // 
            // lambda1
            // 
            this.lambda1.AutoSize = true;
            this.lambda1.Location = new System.Drawing.Point(35, 91);
            this.lambda1.Name = "lambda1";
            this.lambda1.Size = new System.Drawing.Size(23, 17);
            this.lambda1.TabIndex = 0;
            this.lambda1.Text = "λ1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Emperic";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Actual";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(689, 532);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 538);
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
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxLambda2;
        private System.Windows.Forms.TextBox textBoxLambda1;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label tLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label lambda2;
        private System.Windows.Forms.Label lambda1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}

