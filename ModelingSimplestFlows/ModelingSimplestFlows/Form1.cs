using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelingSimplestFlows
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int N;
        private int T;
        private double first_lambda;
        private double second_lambda;
        private int curTime = 0;

        private List<double> time1 = new List<double>();
        private List<double> time2 = new List<double>();
        private List<double> allTime = new List<double>();
        private Dictionary<int, double> empericFrequency = new Dictionary<int, double>();
        private Dictionary<int, double> statisticFrequency = new Dictionary<int, double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            time1.Clear();
            time2.Clear();
            allTime.Clear();
            empericFrequency.Clear();
            statisticFrequency.Clear();
        }

        private int FindFact(int N)
        {
            var result = 1;
            for (int i = 2; i <= N; i++)
            {
                result *= i;
            }
            return result;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ClearData();

            if (textBoxN.Text != "" && textBoxT.Text != "" && textBoxLambda1.Text != "" && textBoxLambda2.Text != "")
            {
                try
                {
                    labelError.Text = "";

                    N = Int32.Parse(textBoxN.Text);
                    T = Int32.Parse(textBoxT.Text);
                    first_lambda = Double.Parse(textBoxLambda1.Text);
                    second_lambda = Double.Parse(textBoxLambda2.Text);

                    time1.Add(0);
                    time2.Add(0);

                    timer1.Start();
                }
                catch
                {
                    labelError.Text = "ERROR: Введены не валидные данные!";
                }
            }
            else
            {
                labelError.Text = "ERROR: Введите все данные!";
            }

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            allTime = time1.Concat(time2).ToList();
            allTime.Sort();

            for (int i = 0; i < N; i++)
            {
                var a = random.NextDouble() * (allTime.Last() - T);
                var cnt = allTime.FindAll(d => d <= a + T && d >= a).Count;

                var value = 0.0;
                empericFrequency.TryGetValue(cnt, out value);
                empericFrequency[cnt] = value + 1;
            }

            for (int i = 0; i < empericFrequency.Keys.Count; i++)
            {
                empericFrequency[empericFrequency.Keys.ToList()[i]] /= N;

                var res = Math.Pow((first_lambda + second_lambda) * T, empericFrequency.Keys.ToList()[i]) / 
                    (double)FindFact(empericFrequency.Keys.ToList()[i]) * Math.Pow(Math.E, -(first_lambda + second_lambda) * T);

                statisticFrequency.Add(empericFrequency.Keys.ToList()[i], res);
            }

            chart1.ChartAreas[0].AxisX.Maximum = empericFrequency.Keys.Max() + 2;
            chart1.ChartAreas[0].AxisX.Minimum = empericFrequency.Keys.Min();

            chart1.Series[0].Points.DataBindXY(empericFrequency.Keys, empericFrequency.Values);
            chart1.Series[1].Points.DataBindXY(statisticFrequency.Keys, statisticFrequency.Values);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var var_time = time1.Last() + Math.Log(random.NextDouble()) / first_lambda;
            time1.Add(var_time);

            var_time = time2.Last() + Math.Log(random.NextDouble()) / second_lambda;
            time2.Add(var_time);

            curTime += timer1.Interval;
            labelTime.Text = "Время: " + (curTime / 1000).ToString() + " сек.";
        }
    }
}
