using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generating_Random_Events
{
    public partial class Form1 : Form
    {
        readonly Random random = new Random();

        //Для приложения "Да или нет"
        const double p = 0.5;

        //Для приложения "Шар предсказаний" 
        readonly List<Answer> Answers = new List<Answer>();

        public Form1()
        {
            InitializeComponent();

            FillingList();

            textBoxAnswerForOrb.ReadOnly = true;
            textBoxAnswerForYesOrNo.ReadOnly = true;
        }

        public void FillingList()
        {
            //Положительные ответы. Суммарная вероятность: 0.24
            Answers.Add(new Answer("Бесспорно", 0.03, Color.LightGreen, Color.Green));
            Answers.Add(new Answer("Предрешено", 0.06, Color.LightGreen, Color.Green));
            Answers.Add(new Answer("Никаких сомнений", 0.07, Color.LightGreen, Color.Green));
            Answers.Add(new Answer("Определённо да", 0.04, Color.LightGreen, Color.Green));
            Answers.Add(new Answer("Можешь быть уверен в этом", 0.04, Color.LightGreen, Color.Green));

            //Нерешительно положительные ответы. Суммарная вероятность: 0.3
            Answers.Add(new Answer("Мне кажется — «да»", 0.09, Color.DarkSeaGreen, Color.DarkSlateBlue));
            Answers.Add(new Answer("Вероятнее всего", 0.03, Color.DarkSeaGreen, Color.DarkSlateBlue));
            Answers.Add(new Answer("Хорошие перспективы", 0.05, Color.DarkSeaGreen, Color.DarkSlateBlue));
            Answers.Add(new Answer("Знаки говорят — «да»", 0.04, Color.DarkSeaGreen, Color.DarkSlateBlue));
            Answers.Add(new Answer("Да", 0.09, Color.DarkSeaGreen, Color.DarkSlateBlue));

            //Нейтральные ответы. Суммарная вероятность: 0.2
            Answers.Add(new Answer("Пока не ясно, попробуй снова", 0.01, Color.Yellow, Color.Orange));
            Answers.Add(new Answer("Спроси позже", 0.05, Color.Yellow, Color.Orange));
            Answers.Add(new Answer("Лучше не рассказывать", 0.04, Color.Yellow, Color.Orange));
            Answers.Add(new Answer("Сейчас нельзя предсказать", 0.03, Color.Yellow, Color.Orange));
            Answers.Add(new Answer("Сконцентрируйся и спроси опять", 0.07, Color.Yellow, Color.Orange));

            //Отрицательные ответы. Суммарная вероятность: 0.26
            Answers.Add(new Answer("Даже не думай", 0.025, Color.LightCoral, Color.Red));
            Answers.Add(new Answer("Мой ответ — «нет»", 0.1, Color.LightCoral, Color.Red));
            Answers.Add(new Answer("По моим данным — «нет»", 0.035, Color.LightCoral, Color.Red));
            Answers.Add(new Answer("Перспективы не очень хорошие", 0.06, Color.LightCoral, Color.Red));
            Answers.Add(new Answer("Весьма сомнительно", 0.04, Color.LightCoral, Color.Red));
        }

        public double GetRand()
        {
            return random.NextDouble();
        }

        public bool GetAnswerForYesOrNo(double alpha)
        {
            if (alpha < p) return true;
            else return false;
        }

        public void GeneratingYesOrNo()
        {
            if(textBoxQuestionForYesOrNo.Text == "")
            {
                errorTextForYesOrNo.Text = "ERROR: Поле пустое! Введите вопрос";
                errorTextForYesOrNo.ForeColor = Color.Red;
                textBoxAnswerForYesOrNo.Text = "";
                textBoxAnswerForYesOrNo.BackColor = Color.White;
            }
            else
            {
                errorTextForYesOrNo.Text = "";
                if (GetAnswerForYesOrNo(GetRand()))
                {
                    textBoxAnswerForYesOrNo.Text = "ДА";
                    textBoxAnswerForYesOrNo.ForeColor = Color.Green;
                    textBoxAnswerForYesOrNo.BackColor = Color.LightGreen;
                }
                else
                {
                    textBoxAnswerForYesOrNo.Text = "НЕТ";
                    textBoxAnswerForYesOrNo.ForeColor = Color.Red;
                    textBoxAnswerForYesOrNo.BackColor = Color.LightCoral;
                }
            }
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            GeneratingYesOrNo();
        }

        public int GetAnswerForOrb(double alpha)
        {
            double A = alpha;
            int k = 0;
            A -= Answers[k].Probability;
            while (A > 0)
            {
                k++;
                A -= Answers[k].Probability;
            }

            return k;
        }

        public void GeneratingOrbForPrediction()
        {
            if (textBoxQuestionForOrb.Text == "")
            {
                errorTextForOrb.Text = "ERROR: Поле пустое! Введите вопрос";
                errorTextForOrb.ForeColor = Color.Red;
                textBoxAnswerForOrb.Text = "";
                textBoxAnswerForOrb.BackColor = Color.White;
            }
            else
            {
                errorTextForOrb.Text = "";
                var index = GetAnswerForOrb(GetRand());
                textBoxAnswerForOrb.Text = Answers[index].Description;
                textBoxAnswerForOrb.BackColor = Answers[index].ColorBack;
                textBoxAnswerForOrb.ForeColor = Answers[index].ColorText;
            }
        }

        private void ButtonForOrb_Click(object sender, EventArgs e)
        {
            GeneratingOrbForPrediction();
        }
    }
}
