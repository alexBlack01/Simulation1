using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Generating_Random_Events
{
    class Answer
    {
        public string Description { get; set; }
        public double Probability { get; set; }
        public Color ColorBack { get; set; }
        public Color ColorText { get; set; }

        public Answer(string description, double probability, Color colorBack, Color colorText)
        {
            this.Description = description;
            this.Probability = probability;
            this.ColorBack = colorBack;
            this.ColorText = colorText;
        }
    }
}
