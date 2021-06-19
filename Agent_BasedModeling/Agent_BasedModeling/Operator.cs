using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_BasedModeling
{
    public class Operator : Agent
    {
        public Operator(double l) 
            :base(l) 
        { 
        }

        public override double NextEvent()
        {
            return Queue.LastTime - Math.Log(random.NextDouble()) / Lambda;
        }

        public override void Process()
        {
            Queue.GuysInWork--;
        }
    }
}
