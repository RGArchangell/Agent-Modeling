using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agent_Modeling
{
    public partial class Form1 : Form
    {
        private double lambda1;
        private double lambda2;
        private int N;

        private double tau = 0;
        private double t = 0;

        private Operator operatorr;
        private Client client;
        private Queue queue;

        private List<Event> flow = new List<Event>();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            tau = 0;
            if (timer.Enabled)
            {
                timer.Stop();
                startButton.Text = "Start";
            }
            else
            {
                readStuff();
                reinitFlow();

                startButton.Text = "Pause";
                timer.Start();
            }
        }

        private void modelButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
                timer.Stop();

            readStuff();
            reinitFlow();
            double numOfExperiments = 1e4;

            List<double> trueVal = new List<double>();
            List<double> theorVal = new List<double>();

            for (int i = 0; i < 1000; i++)
            {
                trueVal.Add(0);
            }

            for (int i = 0; i < numOfExperiments; i++)
            {
                double t = queue.tau;
                doStuff();
                double t_new = queue.tau;

                trueVal[queue.numOnOperators + queue.numQueue] += t_new - t;
            }

            double sum = 0;
            for (int i = 0; i < trueVal.Count; i++)
            {
                sum += trueVal[i];
            }

            for (int i = 0; i < trueVal.Count; i++)
            {
                trueVal[i] /= sum;
            }

            theorVal.Add(0);

            for (int i = 0; i <= N; i++)
            {
                theorVal[0] += (Math.Pow(lambda1 / lambda2, i)) / factorial(i);
            }

            theorVal[0] += Math.Pow(lambda1 / lambda2, N + 1) / (factorial(N) * (N - (lambda1 / lambda2)));
            theorVal[0] = Math.Pow(theorVal[0], -1);

            for (int i = 1; i <= 13; i++)
            {
                if (i < N)
                    theorVal.Add(theorVal[0] * Math.Pow(lambda1 / lambda2, i) / factorial(i));
                else
                    theorVal.Add(theorVal[0] * Math.Pow(lambda1 / lambda2, i) / (factorial(N) * Math.Pow(N, i - N)));
            }

            if (theorVal.Count > trueVal.Count)
            {
                for (int i = 0; i < theorVal.Count - trueVal.Count; i++)
                    trueVal.Add(0);
            }
            else
            {
                for (int i = 0; i < trueVal.Count - theorVal.Count; i++)
                    theorVal.Add(0);
            }

            double MSE = 0;

            for (int i = 0; i < theorVal.Count; i++)
            {
                MSE += Math.Pow(theorVal[i] - trueVal[i], 2);
            }

            MSE /= theorVal.Count;
            errorLabel.Text = "Error: " + MSE;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tau -= 10;
            t += 10;
            if (tau < 0)
            {
                doStuff();
                textBox.Text += "T: " + t + " On operators: " + queue.numOnOperators + " Queue: " + queue.numQueue + "\n";
            }
        }

        private double factorial(double x)
        {
            double f = 1;
            for (int i = 2; i <= x; i++)
            {
                f *= i;
            }

            return f;
        }

        private void reinitFlow()
        {
            this.queue = new Queue();

            this.client = new Client(this.queue, this.lambda1);
            this.operatorr = new Operator(this.queue, this.lambda2);

            this.flow.Clear();
            this.flow.Add(new Event(this.client.getNextEvent(), this.client));
        }

        private void doStuff()
        {
            double min = double.MaxValue;
            Event ev = new Event();

            foreach (Event eve in flow)
            {
                if (eve.tau < min)
                {
                    min = eve.tau;
                    ev = eve;
                }
            }

            tau = ev.tau;
            Agent agent = ev.agent;
            queue.tau = tau;

            agent.processEvent();

            if (agent != operatorr)
                flow.Add(new Event(agent.getNextEvent(), agent));

            if (queue.numOnOperators < N)
            {
                if (queue.numQueue > 0)
                    queue.numQueue--;

                queue.numOnOperators++;
                flow.Add(new Event(operatorr.getNextEvent(), operatorr));
            }

            flow.Remove(ev);
        }
        
        private void readStuff()
        {
            lambda1 = (double)lambda1UpDown.Value;
            lambda2 = (double)lambda2UpDown.Value;
            N = (int)nUpDown.Value;
        }
    }
}
