using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Agent_Modeling
{
    class Client : Agent
    {
        public Client(Queue queue, double lambda) : base(queue, lambda) { }

        public override double getNextEvent()
        {
            return this.queue.tau - (Math.Log(this.random.NextDouble())/this.lambda);
        }

        public override void processEvent()
        {
            queue.numQueue++;
        }
    }
}