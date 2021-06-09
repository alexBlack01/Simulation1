namespace CurRate
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLog = new System.Windows.Forms.Label();
            this.sumDol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valueMoney = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRestart);
            this.panel1.Controls.Add(this.errorLog);
            this.panel1.Controls.Add(this.sumDol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.valueMoney);
            this.panel1.Controls.Add(this.labelMoney);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.buttonSell);
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Controls.Add(this.btCalculate);
            this.panel1.Controls.Add(this.edRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 123);
            this.panel1.TabIndex = 0;
            // 
            // errorLog
            // 
            this.errorLog.AutoSize = true;
            this.errorLog.Location = new System.Drawing.Point(538, 18);
            this.errorLog.Name = "errorLog";
            this.errorLog.Size = new System.Drawing.Size(0, 17);
            this.errorLog.TabIndex = 15;
            // 
            // sumDol
            // 
            this.sumDol.AutoSize = true;
            this.sumDol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumDol.Location = new System.Drawing.Point(668, 71);
            this.sumDol.Name = "sumDol";
            this.sumDol.Size = new System.Drawing.Size(36, 39);
            this.sumDol.TabIndex = 14;
            this.sumDol.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Кол-во долларов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "(доллар к рублю)";
            // 
            // valueMoney
            // 
            this.valueMoney.AutoSize = true;
            this.valueMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueMoney.Location = new System.Drawing.Point(642, 37);
            this.valueMoney.Name = "valueMoney";
            this.valueMoney.Size = new System.Drawing.Size(36, 39);
            this.valueMoney.TabIndex = 10;
            this.valueMoney.Text = "0";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(538, 55);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(98, 17);
            this.labelMoney.TabIndex = 9;
            this.labelMoney.Text = "Кол-во денег:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(273, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 28);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(379, 88);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(100, 28);
            this.buttonSell.TabIndex = 6;
            this.buttonSell.Text = "Продать";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(273, 88);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(100, 28);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(93, 83);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(100, 28);
            this.btCalculate.TabIndex = 4;
            this.btCalculate.Text = "Рассчитать";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Location = new System.Drawing.Point(120, 53);
            this.edRate.Margin = new System.Windows.Forms.Padding(4);
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(73, 22);
            this.edRate.TabIndex = 1;
            this.edRate.Value = new decimal(new int[] {
            8953,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс";
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 50D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 123);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "f2";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1011, 431);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(379, 12);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(129, 28);
            this.buttonRestart.TabIndex = 16;
            this.buttonRestart.Text = "Начать сначала";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 554);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valueMoney;
        private System.Windows.Forms.Label sumDol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorLog;
        private System.Windows.Forms.Button buttonRestart;
    }
}

