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
        private readonly Random random = new Random();
        private readonly List<double> probabilities = new List<double>();

        public Form1()
        {
            InitializeComponent();

            CreateListProbabilities();

        }

        private void CreateListProbabilities()
        {
            for(int i = 0; i < 5; i++)
            {
                probabilities.Add(0.0);
            }
        }

        private void CountProbabilities(TextBox inputTextBox, double value)
        {
            int indexOfExperiment;
            switch (inputTextBox.Name)
            {
                case "textBoxProbability1":
                    indexOfExperiment = 0;
                    break;
                case "textBoxProbability2":
                    indexOfExperiment = 1;
                    break;
                case "textBoxProbability3":
                    indexOfExperiment = 2;
                    break;
                case "textBoxProbability4":
                    indexOfExperiment = 3;
                    break;
                default:
                    return;
            }
            probabilities[indexOfExperiment] = value;

            double sumOfProbabilities = 0;
            for (int i = 0; i < probabilities.Count - 1; i++)
            {
                sumOfProbabilities += probabilities[i];
            }

            if (sumOfProbabilities < 1)
            {
                probabilities[probabilities.Count - 1] = 1 - sumOfProbabilities;
                textBoxProbability5.Text = probabilities[probabilities.Count - 1].ToString();
            }
            else
            {
                textBoxProbability5.Text = "ERROR!";
            }
        }

        private void ChangeValue(object sender)
        {
            if (!(sender is TextBox))
                return;

            var inputText = (TextBox)sender;
            double inputValue;
            try
            {
                inputValue = Convert.ToDouble(inputText.Text);
                CountProbabilities(inputText, inputValue);
            }
            catch
            {
                textBoxProbability5.Text = "ERROR";
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

        private void textBoxProbability1_TextChanged(object sender, EventArgs e)
        {
            ChangeValue(sender);
        }

        private void textBoxProbability2_TextChanged(object sender, EventArgs e)
        {
            ChangeValue(sender);
        }

        private void textBoxProbability3_TextChanged(object sender, EventArgs e)
        {
            ChangeValue(sender);
        }

        private void textBoxProbability4_TextChanged(object sender, EventArgs e)
        {
            ChangeValue(sender);
        }

        private void buttonСalculate_Click(object sender, EventArgs e)
        {
            int numberOfExperiments;
            List<int> statistics = new List<int>() { 0, 0, 0, 0, 0 };
            List<double> frequencies = new List<double>() { 0.0, 0.0, 0.0, 0.0, 0.0 }; ;

            if (textBoxNumberOfExperiments.Text == "" || textBoxProbability5.Text == "ERROR")
                return;

            try
            {
                numberOfExperiments = Convert.ToInt32(textBoxNumberOfExperiments.Text);
            }
            catch 
            { 
                return; 
            }

            probabilityDiagram.Series[0].Points.Clear();
            
            for (int i = 0; i < numberOfExperiments; i++)
            {
                var numberOfEvent = GetNumberOfEvent();
                statistics[numberOfEvent]++;
            }

            for (int i = 0; i < frequencies.Count; i++)
            {
                frequencies[i] = (double)statistics[i] / numberOfExperiments;
                probabilityDiagram.Series[0].Points.AddXY(i + 1, frequencies[i]);
            }
        }
    }
}
