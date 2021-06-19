using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_BasedModeling
{
    public class Customer : Agent
    {
        public Customer(double lamda) 
            : base(lamda) 
        { 
        }

        public override double NextEvent()
        {
            return Queue.LastTime - Math.Log(random.NextDouble()) / Lambda;
        }

        public override void Process()
        {
            Queue.GuysInQueue++;
        }
    }
}
