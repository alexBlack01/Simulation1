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

        double rate = 0;

        int currentDay = 1;

        private void NextValue()
        {
            rate *= (1 + k * (random.NextDouble() - 0.5));
            edRate.Value = (decimal)rate;
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            NextValue();

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
