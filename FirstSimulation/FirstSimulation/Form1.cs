using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstSimulation
{
    public partial class Form1 : Form
    {
        Dictionary<CheckBox, Cell> field = new Dictionary<CheckBox, Cell>();
        Dictionary<CellState, int> priceValues = new Dictionary<CellState, int>();

        private int currentValue = 100;
        private int currentDayValue = 0;
        private double currentSpeed = 1;
        private int speedValue = 1000;

        public Form1()
        {
            InitializeComponent();
            foreach (CheckBox cb in panel1.Controls)
                field.Add(cb, new Cell());

            priceValues.Add(CellState.Empty, 0);
            priceValues.Add(CellState.Green, -1);
            priceValues.Add(CellState.Planted, -1);
            priceValues.Add(CellState.Immature, 3);
            priceValues.Add(CellState.Mature, 5);
            priceValues.Add(CellState.Overgrow, -1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) Plant(cb);
            else Harvest(cb);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            string str;
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                str = radioButton.Text.Substring(1);
                currentSpeed = Convert.ToDouble(str);
                timer1.Interval = (int)(speedValue / currentSpeed);
            }
        }

        private void Plant(CheckBox cb)
        {
            currentValue -= 2;
            field[cb].Plant();
            UpdateMoney();
            UpdateBox(cb);
        }

        private void Harvest(CheckBox cb)
        {
            currentValue += priceValues[field[cb].state];
            field[cb].Harvest();
            UpdateMoney();
            UpdateBox(cb);
        }

        private void NextStep(CheckBox cb)
        {
            field[cb].NextStep();
            UpdateBox(cb);
        }

        private void UpdateBox(CheckBox cb)
        {
            Color c = Color.White;
            switch (field[cb].state)
            {
                case CellState.Planted:
                    c = Color.Black;
                    break;
                case CellState.Green:
                    c = Color.Green;
                    break;
                case CellState.Immature:
                    c = Color.Yellow;
                    break;
                case CellState.Mature:
                    c = Color.Red;
                    break;
                case CellState.Overgrow:
                    c = Color.Brown;
                    break;
            }
            cb.BackColor = c;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            foreach (CheckBox cb in panel1.Controls)
                NextStep(cb);

            UpdateDay();
        }

        private void UpdateMoney()
        {
            currentBalance.Text = currentValue + " монет";
        }

        private void UpdateDay()
        {
            currentDayValue++;
            currentDay.Text = currentDayValue.ToString();
        }
    }
}
