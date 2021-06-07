using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherSimulator
{

    public partial class Form1 : Form
    {
        private string path = Directory.GetCurrentDirectory();
        private Random random = new Random();
        private List<Weather> Weathers = new List<Weather>();
        private double[,] matrix = { { -0.4, 0.3, 0.1 }, { 0.4, -0.8, 0.4 }, { 0.1, 0.4, -0.5 } };
        private int N;
        private int T;
        private int k = 0;
        private int[] Freq = new int[3] { 0, 0, 0 };
        private double[] Freq_Dur = new double[3] { 0, 0, 0 };
        private int i;

        public Form1()
        {
            InitializeComponent();

            CreateWeathers();
        }

        public void CreateWeathers()
        {
            Weathers.Add(new Weather("Солнечно", path + "\\sun.png", 1));
            Weathers.Add(new Weather("Облачно", path + "\\cloudy.png", 2));
            Weathers.Add(new Weather("Дождь", path + "\\rainy.png", 3));
        }

        public int SimulationMarkovProcess(int i)
        {
            double t = 0;
            double alpha;
            double[] mas = new double[3] { 0, 0, 0 };
            double p;

            while (t < T)
            {
                alpha = random.NextDouble();
                double teta = Math.Log(alpha) / matrix[i, i];
                t += teta;

                for(int j = 0; j < 3; j++)
                {
                    if(i == j)
                    {
                        mas[j] = 0;
                    }
                    else
                    {
                        mas[j] = -matrix[i, j] / matrix[i, i];
                    }
                }

                p = random.NextDouble();

                i = 0;
                p -= mas[i];
                while (p > 0)
                {
                    i++;
                    p -= mas[i];
                }

                labelWeather.Text = "Погода: " + Weathers[i].Name;
                pictureBox1.ImageLocation = Weathers[i].Path;
            }

            return i;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(textBoxN.Text != "" && textBoxT.Text != "")
            {
                labelError.Text = "";

                N = Int32.Parse(textBoxN.Text);
                T = Int32.Parse(textBoxT.Text);

                i = random.Next(0, 2);

                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                labelError.Text = "ERROR: Введите валидные данные!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(k < N)
            {
                i = SimulationMarkovProcess(i);
                Freq[i]++;
                k++;

                labelDateTime.Text = string.Format("Текущее время: {0}", DateTime.Now.ToString("HH:mm:ss"));

                for (int i = 0; i < 3; i++)
                {
                    Freq_Dur[i] = (double)Freq[i] / (double)N;
                    chart1.Series[0].Points.AddXY(i + 1, Freq[i]);
                }

                labelDurSuny.Text = Freq_Dur[0].ToString();
                labelDurCloudy.Text = Freq_Dur[1].ToString();
                labelDurRainy.Text = Freq_Dur[2].ToString();

            }
        }

        private void buttonFinish_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
        }
    }
}
