using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double dt = 0.01;
        const double g = 9.81;

        double a;
        double v0;
        double y0;

        double aRad;
        double maxHeight;
        double maxLength;

        double t;
        double x;
        double y;
        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;
            btPause.Enabled = true;
            edAngle.Enabled = false;
            edSpeed.Enabled = false;
            edHeight.Enabled = false;

            a = (double)edAngle.Value;
            v0 = (double)edSpeed.Value;
            y0 = (double)edHeight.Value;

            t = 0;
            x = 0;
            y = y0;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x, y);

            aRad = a * Math.PI / 180;
            maxHeight = y0 + v0 * v0 * Math.Sin(aRad) * Math.Sin(aRad) / (2 * g);
            maxLength = v0 * Math.Cos(aRad) * (v0 * Math.Sin(aRad) / g + Math.Sqrt(2 * maxHeight / g));
            chart1.ChartAreas[0].AxisX.Maximum = maxLength * 1.1;
            chart1.ChartAreas[0].AxisY.Maximum = maxHeight * 1.1;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            timeLabel.Text = $"{t} сек";
            x = v0 * Math.Cos(aRad) * t;
            y = y0 + v0 * Math.Sin(aRad) * t - g * t * t / 2;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
            {
                timer1.Stop();
                btStart.Enabled = true;
                btPause.Enabled = false;
                edAngle.Enabled = true;
                edSpeed.Enabled = true;
                edHeight.Enabled = true;
            }
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}
