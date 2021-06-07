
namespace WeatherSimulator
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWeather = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelError = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonFinish = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSuny = new System.Windows.Forms.Label();
            this.labelCloudy = new System.Windows.Forms.Label();
            this.labelRainy = new System.Windows.Forms.Label();
            this.labelDurSuny = new System.Windows.Forms.Label();
            this.labelDurRainy = new System.Windows.Forms.Label();
            this.labelDurCloudy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 39);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(95, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeather.Location = new System.Drawing.Point(14, 242);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(113, 31);
            this.labelWeather.TabIndex = 3;
            this.labelWeather.Text = "Погода:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(20, 87);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(104, 22);
            this.textBoxN.TabIndex = 4;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(20, 149);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(104, 22);
            this.textBoxT.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите T";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateTime.Location = new System.Drawing.Point(14, 480);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(226, 31);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Текущее время: ";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(423, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(699, 482);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(20, 178);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(130, 12);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(112, 39);
            this.buttonFinish.TabIndex = 11;
            this.buttonFinish.Text = "Закончить";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.11355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.88645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSuny, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCloudy, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRainy, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDurSuny, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDurRainy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDurCloudy, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(590, 519);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 65);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Состояние";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Частота";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSuny
            // 
            this.labelSuny.AutoSize = true;
            this.labelSuny.Location = new System.Drawing.Point(108, 0);
            this.labelSuny.Name = "labelSuny";
            this.labelSuny.Size = new System.Drawing.Size(73, 17);
            this.labelSuny.TabIndex = 2;
            this.labelSuny.Text = "Солнечно";
            // 
            // labelCloudy
            // 
            this.labelCloudy.AutoSize = true;
            this.labelCloudy.Location = new System.Drawing.Point(200, 0);
            this.labelCloudy.Name = "labelCloudy";
            this.labelCloudy.Size = new System.Drawing.Size(67, 17);
            this.labelCloudy.TabIndex = 3;
            this.labelCloudy.Text = "Облачно";
            // 
            // labelRainy
            // 
            this.labelRainy.AutoSize = true;
            this.labelRainy.Location = new System.Drawing.Point(291, 0);
            this.labelRainy.Name = "labelRainy";
            this.labelRainy.Size = new System.Drawing.Size(51, 17);
            this.labelRainy.TabIndex = 4;
            this.labelRainy.Text = "Дождь";
            // 
            // labelDurSuny
            // 
            this.labelDurSuny.AutoSize = true;
            this.labelDurSuny.Location = new System.Drawing.Point(108, 32);
            this.labelDurSuny.Name = "labelDurSuny";
            this.labelDurSuny.Size = new System.Drawing.Size(0, 17);
            this.labelDurSuny.TabIndex = 5;
            this.labelDurSuny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDurRainy
            // 
            this.labelDurRainy.AutoSize = true;
            this.labelDurRainy.Location = new System.Drawing.Point(291, 32);
            this.labelDurRainy.Name = "labelDurRainy";
            this.labelDurRainy.Size = new System.Drawing.Size(0, 17);
            this.labelDurRainy.TabIndex = 6;
            // 
            // labelDurCloudy
            // 
            this.labelDurCloudy.AutoSize = true;
            this.labelDurCloudy.Location = new System.Drawing.Point(200, 32);
            this.labelDurCloudy.Name = "labelDurCloudy";
            this.labelDurCloudy.Size = new System.Drawing.Size(0, 17);
            this.labelDurCloudy.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 622);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSuny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCloudy;
        private System.Windows.Forms.Label labelRainy;
        private System.Windows.Forms.Label labelDurSuny;
        private System.Windows.Forms.Label labelDurRainy;
        private System.Windows.Forms.Label labelDurCloudy;
    }
}

