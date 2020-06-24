using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Agent_Modeling
{
    public struct Event
    {
        public double tau;
        public Agent agent;

        public Event(double tau, Agent agent)
        {
            this.tau = tau;
            this.agent = agent;
        }

        public static bool operator == (Event e1, Event e2)
        {
            return e1.Equals(e2);
        }
        public static bool operator != (Event e1, Event e2)
        {
            return !e1.Equals(e2);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}