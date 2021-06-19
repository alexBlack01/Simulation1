using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agent_BasedModeling
{
    public partial class Form1 : Form
    {
        private double first_lambda;
        private double secind_lambda;
        private int N;

        private Operator _operator;
        private Customer _customer;
        private Queue _queue;

        private List<(double, Agent)> queue = new List<(double, Agent)>();
        private List<double> s = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private int FindFact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * FindFact(n - 1);
            } 
        }

        private void ClearData()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            queue.Clear();
            logs.Items.Clear();
        }

        private void PrintLogs(Agent agent)
        {
            var str = "Агент: " + agent.GetType() + ", Очередь: " + _queue.GuysInQueue + ", Процесс: " + _queue.GuysInWork + ", Время: " + _queue.LastTime;
            logs.Items.Add(str);
        }

        private Agent Working()
        {
            var ev = queue.Min();
            queue.Remove(ev);

            _queue.Time.Add(ev.Item1);

            if (ev.Item2 != _operator)
            {
                queue.Add((ev.Item2.NextEvent(), ev.Item2));
            }

            ev.Item2.Process();

            var operators = queue.FindAll(x => x.Item2 == _operator).Count;

            if (operators < N && operators < _queue.GuysInQueue + _queue.GuysInWork)
            {
                _queue.GuysInQueue--;
                _queue.GuysInWork++;
                queue.Add((_operator.NextEvent(), _operator));
            }

            return ev.Item2;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ClearData();

            if(textBoxIntensity1.Text != "" && textBoxIntensity1.Text != "" && textBoxIntensity1.Text != "")
            {
                try
                {
                    labelError.Text = "";

                    first_lambda = Double.Parse(textBoxIntensity1.Text);
                    secind_lambda = Double.Parse(textBoxIntensity2.Text);
                    N = Int32.Parse(textBoxOperators.Text);

                    _queue = new Queue();
                    _operator = new Operator(first_lambda);
                    _customer = new Customer(secind_lambda);

                    _operator.SetQueue(_queue);
                    _customer.SetQueue(_queue);

                    queue.Add((_customer.NextEvent(), _customer));

                    timer1.Start();
                }
                catch
                {
                    labelError.Text = "Введите валидные данные!";
                }
            }
            else
            {
                labelError.Text = "Введите все данные!";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            List<double> p = new List<double> { 0.0 };
            var cntStats = 100000;
            var maxFact = 20;

            timer1.Stop();

            s = Enumerable.Repeat(0.0, 50).ToList();

            for (int i = 0; i < cntStats; i++)
            {
                var oldT = _queue.LastTime;
                var nPeople = _queue.GuysInQueue + _queue.GuysInWork;

                Working();

                var newT = _queue.LastTime;
                s[nPeople] += newT - oldT;
            }

            var sum = s.Sum();

            for (int i = 0; i < s.Count; i++)
            {
                s[i] /= sum;
            }

            var rho = secind_lambda / first_lambda;

            for (int i = 0; i <= N; i++)
            {
                p[0] += Math.Pow(rho, i) / (double)FindFact(i);
            }

            p[0] += Math.Pow(rho, N + 1) / ((double)FindFact(N) * (N - rho));
            p[0] = Math.Pow(p[0], -1);

            for (int i = 1; i <= maxFact; i++)
            {
                double pTmp;

                if (i < N)
                {
                    pTmp = p[0] * Math.Pow(rho, i) / (double)FindFact(i);
                }
                else
                {
                    pTmp = p[0] * Math.Pow(rho, i) / ((double)FindFact(N) * Math.Pow(N, i - N));
                }

                p.Add(pTmp);
            }

            for (int i = 0; i < s.FindLastIndex(x => x != 0); i++)
            {
                chart1.Series[0].Points.AddXY(i, s[i]);
                chart1.Series[1].Points.AddXY(i, p[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PrintLogs(Working());
        }
    }
}
