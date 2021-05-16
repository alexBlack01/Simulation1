using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventGenerationExperimentStatistics
{
    public partial class Form1 : Form
    {
        private const double chiSquareValue = 9.488;
        private readonly Random random = new Random();
        private readonly List<double> probabilities = new List<double>();
        private int experiments;
        private double succesProbability;
        private double loseProbability;
        private const double minProbability = 0.0000000000000001;
        private const int numProbabilitiesForChi = 4;

        public Form1()
        {
            InitializeComponent();

            labelAverage.Text = "";
            labelVariance.Text = "";
            labelChiSquare.Text = "";
        }

        private void GeometryProbability()
        {
            probabilities.Clear();
            double probability = 1;
            int i = 0;
            while (probability > minProbability)
            {
                probability = succesProbability * Math.Pow(loseProbability, i);
                probabilities.Add(probability);
                i++;
            }
        }

        private int GetNumberOfEvent()
        {
            double randomValue;
            randomValue = random.NextDouble();

            int i = 0;
            randomValue -= probabilities[i];

            while (randomValue > 0)
            {
                i++;
                randomValue -= probabilities[i];
            }

            return i;
        }

        private void buttonСalculate_Click(object sender, EventArgs e)
        {
            int numberOfExperiments = probabilities.Count;
            List<int> statistics = new List<int>();
            List<double> frequencies = new List<double>();
            double average = 0;                 // мат.ожидание
            double squareAverage = 0;           // квадрат мат.ожидания
            double variance = 0;                // дисперсия
            double empiricAverage = 0;          // эмиприческое мат.ожидание
            double empericSquareAverage = 0;    // эмипрический квадрат мат.ожидания
            double empiricVariance = 0;         // эмпирическая дисперсия
            double absoluteAverangeError;       // абсолютная ошибка мат.ожидания
            double absoluteVarianceError;       // абсолютная ошибка дисперсии
            double relativeAverangeError;       // относительная ошибка мат.ожидания
            double relativeVarianceError;       // относительная ошибка дисперсии
            double chiSquared = 0;              // хи-квадрат
            double sumOfCountableProb = 0;
            double sumOfCountableStat = 0;

            labelError.Text = "";
            probabilityDiagram.Series[0].Points.Clear();

            try
            {
                numberOfExperiments = Convert.ToInt32(textBoxNumberOfExperiments.Text);
                succesProbability = Convert.ToDouble(probTrue.Text);
                loseProbability = 1 - succesProbability;
            }
            catch
            {
                labelError.Text = "ERROR: Не валидные данные!";
                return;
            }
            if (succesProbability < 0 || succesProbability > 1)
            {
                labelError.Text = "ERROR: Значение вероятности должно быть от 0 до 1!";
                return;
            }
            if (numberOfExperiments < 1)
            {
                labelError.Text = "ERROR: Экспериментов должно быть больше одного!";
                return;
            }

            GeometryProbability();

            for (int i = 0; i < numberOfExperiments; i++)
            {
                statistics.Add(0);
                frequencies.Add(0.0);
            }

            for (int i = 0; i < numberOfExperiments; i++)
            {
                var numberOfEvent = GetNumberOfEvent();
                statistics[numberOfEvent]++;
            }            

            for (int i = 0; i < probabilities.Count; i++)
            {
                average += probabilities[i] * (i + 1);
                squareAverage += probabilities[i] * Math.Pow(i + 1, 2);
            }
            variance = squareAverage - Math.Pow(average, 2);

            for (int i = 0; i < numberOfExperiments; i++)
            {
                frequencies[i] = (double)statistics[i] / numberOfExperiments;
                probabilityDiagram.Series[0].Points.AddXY(i, frequencies[i]);

                empiricAverage += frequencies[i] * (i + 1);
                empericSquareAverage += frequencies[i] * Math.Pow(i + 1, 2);
            }
            empiricVariance = empericSquareAverage - Math.Pow(empiricAverage, 2);

            absoluteAverangeError = Math.Abs(empiricAverage - average);
            absoluteVarianceError = Math.Abs(empiricVariance - variance);
            relativeAverangeError = (double)absoluteAverangeError / Math.Abs(average);
            relativeVarianceError = (double)absoluteVarianceError / Math.Abs(variance);

            var avError = Math.Round(relativeAverangeError * 100, 2);
            var vError = Math.Round(relativeVarianceError * 100, 2);
            labelAverage.Text = Math.Round(empiricAverage, 3).ToString() + $" (error = {avError}%)";
            labelVariance.Text = Math.Round(empiricVariance, 3).ToString() + $" (error = {vError}%)";

            var N = numberOfExperiments;
            for (int i = 0; i < numProbabilitiesForChi; i++)
            {
                var n = statistics[i];
                var p = probabilities[i];
                chiSquared += (double)Math.Pow(n, 2) / (N * p);
                sumOfCountableProb += p;
                sumOfCountableStat += n;
            }
            var last_n = N - sumOfCountableStat;
            var last_p = 1 - sumOfCountableProb;
            chiSquared += (double)(last_n * last_n) / (N * last_p);
            chiSquared -= N;
            chiSquared = Math.Round(chiSquared, 2);

            if (chiSquared > chiSquareValue)
                labelChiSquare.Text = $"{chiSquared} > {chiSquareValue} is false";
            else
                labelChiSquare.Text = $"{chiSquared} < {chiSquareValue} is true";
        }

    }
}
