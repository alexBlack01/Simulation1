using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Flight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BusinessModel businessModel = new BusinessModel();

        
        private void btStart_Click(object sender, EventArgs e)
        {
            businessModel.StartFlight(
                (double)edAngle.Value,
                (double)edSpeed.Value,
                (double)edHeight.Value,
                (double)edWeight.Value,
                (double)edSquare.Value
                );
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(businessModel.X, businessModel.Y);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            businessModel.GenerateNextPoint();
            chart1.Series[0].Points.AddXY(businessModel.X, businessModel.Y);
            if (businessModel.Y <= 0) timer1.Stop();
        }
    }
}
