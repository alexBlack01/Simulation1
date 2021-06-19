using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_BasedModeling
{
    public class Queue
    {
        public int GuysInQueue { get; set; }
        public int GuysInWork { get; set; }
        public List<double> Time { get; } = new List<double> { 0 };
        public double LastTime => Time.Last();
    }
}
