using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishonestDice
{
    public partial class Form1 : Form
    {
        private List<double> rightDice = new List<double>() { 0.16, 0.16, 0.16, 0.16, 0.16, 0.16 };
        private List<double> wrongDice = new List<double>() { 0.1, 0.25, 0.02, 0.2, 0.3, 0.13 };

        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            labelError1.Text = "";
            labelResult1.Text = "";
            labelResultText1.Text = "";
            labelError2.Text = "";
            labelResult2.Text = "";
            labelResultText2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("В игре 2 кубика и на каждом из них может выпасть от 1 до 6 очков. Игрок загадывает число от 2 до 12, затем бросает кости. После броска показывается количество очков, выпавших на костях.");
            sb.AppendLine("Конечное число выигранных очков будет высчитываться по формуле: x - (|x - y|) * 2, где:");
            sb.AppendLine("x - количество очков выпавшее на костях");
            sb.AppendLine("y - загаданное число очков");
            sb.AppendLine("То есть конечным количеством очков будет количество выпавших на костях очков минус удвоенная ошибка в догадке.");
            sb.AppendLine("Игрок выигрывает, если в результате выходит количество очков больше нуля.");

            MessageBox.Show(
                sb.ToString(),
                "Правила игры",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private int GetEvent(bool varCube)
        {
            double A = random.NextDouble();
            List<double> dice = new List<double>();

            if (varCube)
            {
                dice.AddRange(rightDice.ToArray());
            }
            else
            {
                dice.AddRange(wrongDice.ToArray());
            }

            int i = 0;
            A -= dice[i];

            while (A > 0)
            {
                i++;
                A -= dice[i];
            }
            return i + 1;
        }

        private double GetResult(int diceValue1, int diceValue2, double number)
        {
            return diceValue1 + diceValue2 - Math.Abs(diceValue1 + diceValue2 - number) * 2;
        }

        private void buttonRollDice1_Click(object sender, EventArgs e)
        {
            double inputNumber;
            if (textBoxNumber1.Text != "")
            {
                try
                {
                    inputNumber = Convert.ToDouble(textBoxNumber1.Text);
                    if (inputNumber < 2 || inputNumber > 12)
                    {
                        labelError1.Text = "ERROR: Введите число в указанном диапазоне!";
                        labelError1.ForeColor = Color.Red;
                        labelResult1.Text = "";
                        labelResultText1.Text = "";
                        textBoxDice11.Text = "";
                        textBoxDice12.Text = "";
                        return;
                    }

                    labelError1.Text = "";

                    var diceValue1 = GetEvent(true);
                    var diceValue2 = GetEvent(true);

                    textBoxDice11.Text = diceValue1.ToString();
                    textBoxDice12.Text = diceValue2.ToString();

                    var result = GetResult(diceValue1, diceValue2, inputNumber);

                    if (Math.Abs(result) == 1)
                    {
                        labelResult1.Text = result.ToString() + " очко";
                    }
                    if (Math.Abs(result) >= 2 && Math.Abs(result) <= 4)
                    {
                        labelResult1.Text = result.ToString() + " очка";
                    }
                    if (Math.Abs(result) == 0 || Math.Abs(result) >= 5)
                    {
                        labelResult1.Text = result.ToString() + " очков";
                    }

                    if (result > 0)
                    {
                        labelResultText1.Text = "Вы победили!";
                        labelResultText1.ForeColor = Color.Green;
                    }
                    else
                    {
                        labelResultText1.Text = "Вы проиграли!";
                        labelResultText1.ForeColor = Color.Red;
                    }
                }
                catch
                {
                    labelError1.Text = "ERROR: Введите корректные данные!";
                    labelError1.ForeColor = Color.Red;
                    labelResult1.Text = "";
                    labelResultText1.Text = "";
                    textBoxDice11.Text = "";
                    textBoxDice12.Text = "";
                }
            }
            else
            {
                labelError1.Text = "ERROR: Введите сначала число!";
                labelError1.ForeColor = Color.Red;
                labelResult1.Text = "";
                labelResultText1.Text = "";
                textBoxDice11.Text = "";
                textBoxDice12.Text = "";
            }
        }

        private void buttonRollDice2_Click(object sender, EventArgs e)
        {
            double inputNumber;
            if (textBoxNumber2.Text != "")
            {
                try
                {
                    inputNumber = Convert.ToDouble(textBoxNumber2.Text);
                    if (inputNumber < 2 || inputNumber > 12)
                    {
                        labelError2.Text = "ERROR: Введите число в указанном диапазоне!";
                        labelError2.ForeColor = Color.Red;
                        labelResult2.Text = "";
                        labelResultText2.Text = "";
                        textBoxDice21.Text = "";
                        textBoxDice22.Text = "";
                        return;
                    }

                    labelError2.Text = "";

                    var diceValue1 = GetEvent(false);
                    var diceValue2 = GetEvent(false);

                    textBoxDice21.Text = diceValue1.ToString();
                    textBoxDice22.Text = diceValue2.ToString();

                    var result = GetResult(diceValue1, diceValue2, inputNumber);

                    if(Math.Abs(result) == 1)
                    {
                        labelResult2.Text = result.ToString() + " очко";
                    }
                    if(Math.Abs(result) >= 2 && Math.Abs(result) <= 4)
                    {
                        labelResult2.Text = result.ToString() + " очка";
                    }
                    if(Math.Abs(result) == 0 || Math.Abs(result) >= 5)
                    {
                        labelResult2.Text = result.ToString() + " очков";
                    }
                    

                    if (result > 0)
                    {
                        labelResultText2.Text = "Вы победили!";
                        labelResultText2.ForeColor = Color.Green;
                    }
                    else
                    {
                        labelResultText2.Text = "Вы проиграли!";
                        labelResultText2.ForeColor = Color.Red;
                    }
                }
                catch
                {
                    labelError2.Text = "ERROR: Введите корректные данные!";
                    labelError2.ForeColor = Color.Red;
                    labelResult2.Text = "";
                    labelResultText2.Text = "";
                    textBoxDice21.Text = "";
                    textBoxDice22.Text = "";
                }
            }
            else
            {
                labelError2.Text = "ERROR: Введите сначала число!";
                labelError2.ForeColor = Color.Red;
                labelResult2.Text = "";
                labelResultText2.Text = "";
                textBoxDice21.Text = "";
                textBoxDice22.Text = "";
            }
        }
    }
}
