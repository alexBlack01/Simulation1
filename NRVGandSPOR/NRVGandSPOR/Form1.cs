using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRVGandSPOR
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        private List<double> values = new List<double>();
        private List<double> probabilities = new List<double>();
        private Interval[] intervalInfo;
        private int n;
        private int k;
        private double mean;
        private double variance;

        public Form1()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
        }

        private void GenerateGaussianValues()
        {
            for (int index = 0; index < n; index++)
            {
                double alphaSum = 0;
                for (int i = 0; i < n; i++)
                {
                    var alpha = random.NextDouble();
                    alphaSum += alpha;
                }
                var result = Math.Sqrt((double)12 / n) * (alphaSum - (double)n / 2);
                result = result * Math.Sqrt(variance) + mean;
                values.Add(result);
            }
        }

        private void GetHistogramm()
        {
            var log2N = Math.Log(n, 2) + 1;
            k = (int)Math.Round(log2N);
            var intervalSize = (values.Last() - values.First() + 0.01) / k;

            intervalInfo = new Interval[k];
            double leftIntervalBorder = values.First();
            double rightIntervalBorder = leftIntervalBorder + intervalSize;
            for (int i = 0; i < k; i++)
            {
                intervalInfo[i] = new Interval();

                intervalInfo[i].rightBorder = rightIntervalBorder;
                intervalInfo[i].leftBorder = leftIntervalBorder;
                for (int j = 0; j < n; j++)
                {
                    if (values[j] < leftIntervalBorder)
                        continue;
                    if (values[j] > rightIntervalBorder)
                        break;

                    intervalInfo[i].NumberOfValues++;
                }
                intervalInfo[i].frequency = (double)intervalInfo[i].NumberOfValues / n;

                leftIntervalBorder = rightIntervalBorder;
                rightIntervalBorder += intervalSize;

                var centerOfColumn = (intervalInfo[i].rightBorder + intervalInfo[i].leftBorder) / 2;
                centerOfColumn = Math.Round(centerOfColumn, 4);
                var right = Math.Round(intervalInfo[i].rightBorder, 3);
                var left = Math.Round(intervalInfo[i].leftBorder, 3);
                chart1.Series[0].Points.AddXY(centerOfColumn, intervalInfo[i].frequency);
                chart1.Series[1].Points.AddXY(centerOfColumn, intervalInfo[i].frequency);
                chart1.Series[0].Points.Last().Label = $"[{left};{right}]";
            }

        }

        private double CountGausseProb(double x)
        {
            double prob;
            var part1 = 1 / (Math.Sqrt(2 * Math.PI * variance));
            var grade = 0 - ((x - mean) * (x - mean) / (2 * variance));
            var part2 = Math.Pow(Math.E, grade);
            prob = part1 * part2;
            return prob;
        }

        private void CountCharacteristics()
        {
            double empiricAverage = 0;
            double empericSquareAverage = 0;
            double empiricVariance = 0;
            foreach (var x in values)
            {
                empiricAverage += x;
                empericSquareAverage += x * x;
            }
            empiricAverage /= n;
            empericSquareAverage /= n;
            empiricVariance = empericSquareAverage - (empiricAverage * empiricAverage);

            double absoluteAverangeError = Math.Abs(mean - empiricAverage);
            double absoluteVarianceError = Math.Abs(empiricVariance - variance);
            var meanMark = mean;
            if (mean == 0)
            {
                meanMark = 1;
            }
            double relativeAverangeError = (double)absoluteAverangeError / Math.Abs(meanMark);
            double relativeVarianceError = (double)absoluteVarianceError / Math.Abs(variance);

            var avError = Math.Round(relativeAverangeError * 100, 2);
            var vError = Math.Round(relativeVarianceError * 100, 2);
            averageLabel.Text = Math.Round(empiricAverage, 3).ToString() + $" (error = {avError}%)";
            varianceLabel.Text = Math.Round(empiricVariance, 3).ToString() + $" (error = {vError}%)";

            double chiValue = 0;
            switch (k)
            {
                case 4:
                    chiValue = 7.815;
                    break;

                case 8:
                    chiValue = 14.067;
                    break;

                case 11:
                    chiValue = 18.307;
                    break;

                case 14:
                    chiValue = 22.362;
                    break;
            }

            double chiSquared = 0;
            foreach (var interval in intervalInfo)
            {
                var ni = interval.NumberOfValues;
                var a = interval.leftBorder;
                var b = interval.rightBorder;
                var pi = (b - a) * CountGausseProb((b + a) / 2);
                chiSquared += (ni * ni) / (n * pi);
            }
            chiSquared -= n;
            chiSquared = Math.Round(chiSquared, 2);

            if (chiSquared > chiValue)
                chiSquareLabel.Text = $"{chiSquared} > {chiValue} is false";
            else
                chiSquareLabel.Text = $"{chiSquared} < {chiValue} is true";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            values.Clear();
            probabilities.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            n = Convert.ToInt32(comboBox2.Text);
            mean = (double)numericUpDown4.Value;
            variance = (double)numericUpDown3.Value;

            GenerateGaussianValues();
            values.Sort();

            GetHistogramm();
            CountCharacteristics();
        }
    }
}
