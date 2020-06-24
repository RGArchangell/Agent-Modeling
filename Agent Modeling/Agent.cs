using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Agent_Modeling
{
    public abstract class Agent
    {
        protected Random random = new Random();

        protected Queue queue;

        protected double lambda;
        
        public abstract double getNextEvent();
        public abstract void processEvent();

        public Agent(Queue queue, double lambda)
        {
            this.queue = queue;
            this.lambda = lambda;
        }
    }
}