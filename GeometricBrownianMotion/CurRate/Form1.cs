using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btCalculate.Enabled = false;
            buttonBuy.Enabled = false;
            buttonSell.Enabled = false;
            buttonRestart.Enabled = false;

            valueMoney.Text = startMoney.ToString() + " руб.";
            sumDol.Text = "0 дол.";
        }

        const double k = 0.02;
        Random random = new Random();

        const double startMoney = 500;

        double currentDol = 0;
        double currentRub = 0;

        double next_time = 0;
        double this_time = 0;

        double rate = 0;

        int currentDay = 1;

        private double CountGausseProb()
        {
            double variance = 1;
            double mean = 0;
            double prob;

            var res1 = Math.Sqrt(-2 * Math.Log(random.NextDouble())) * Math.Cos(2 * Math.PI * random.NextDouble());
            var res2 = mean + res1 * variance;
            prob = res2;
            return prob;
        }

        private void NextValue(double next_t, double now_t)
        {
            double mu = 0.1;
            double sigma = 0.09;
            var res1 = Math.Pow(sigma, 2) * 0.5;
            var dt = next_t - now_t;
            var res_gaus = CountGausseProb() * Math.Sqrt(dt);
            var res2 = sigma * res_gaus;
            var res = (mu - res1) * dt + res2;
            rate *= Math.Exp(res);
            edRate.Value = (decimal)rate;
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            next_time += 0.01;
            NextValue(next_time, this_time);

            this_time = next_time;

            currentDay++;
            chart1.Series[0].Points.AddXY(currentDay, rate);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            edRate.Enabled = false;
            btCalculate.Enabled = true;
            buttonBuy.Enabled = true;
            buttonSell.Enabled = true;
            buttonStart.Enabled = false;
            buttonRestart.Enabled = true;

            rate = (double)edRate.Value;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(currentDay, rate);

            currentRub = startMoney;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if(currentRub >= rate)
            {
                currentDol++;
                currentRub -= rate;

                valueMoney.Text = currentRub.ToString() + " руб.";
                sumDol.Text = currentDol.ToString() + " дол.";
                errorLog.Text = "";
            }
            else
            {
                errorLog.Text = "ERROR: У вас не хватает средств!";
            }
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (currentDol > 0)
            {
                currentDol--;
                currentRub += rate;

                valueMoney.Text = currentRub.ToString() + " руб.";
                sumDol.Text = currentDol.ToString() + " дол.";
                errorLog.Text = "";
            }
            else
            {
                errorLog.Text = "ERROR: У вас не хватает средств!";
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            btCalculate.Enabled = false;
            buttonBuy.Enabled = false;
            buttonSell.Enabled = false;
            buttonStart.Enabled = true;
            buttonRestart.Enabled = false;
            edRate.Enabled = true;

            valueMoney.Text = startMoney.ToString() + " руб.";

            chart1.Series[0].Points.Clear();

            currentDay = 1;

            sumDol.Text = "0 дол.";
        }
    }
}
