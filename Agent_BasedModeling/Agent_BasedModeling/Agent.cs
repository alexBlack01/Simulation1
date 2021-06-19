using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_BasedModeling
{
    public abstract class Agent
    {
        public Queue Queue { get; protected set; }
        public double Lambda { get; }

        protected Random random = new Random();

        protected Agent(double l)
        {
            this.Lambda = l;
        }

        public abstract double NextEvent();
        public abstract void Process();

        public void SetQueue(Queue queue)
        {
            this.Queue = queue;
        }
    }
}
