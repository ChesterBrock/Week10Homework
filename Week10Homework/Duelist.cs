using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Homework
{
    class Duelist
    {
        private String name;
        private double probabilityOfHitting;
        private bool isAlive = true;

        public string Name { get => name; set => name = value; }
        public double ProbabilityOfHitting { get => probabilityOfHitting; set => probabilityOfHitting = value; }
        public bool IsAlive { get => isAlive; set => isAlive = value; }

        // constructor 
        public Duelist(String tempName, double tempProbability)
        {
            name = tempName;
            probabilityOfHitting = tempProbability;
        }
        bool getAlive()
        {

            return isAlive;
        }

        private static Random rand = new Random(0);

        public void shootAtTarget(Duelist target)
        {
            var rand = new Random();
            if (this.probabilityOfHitting == 1)
            {
                target.IsAlive = false;
                target.getAlive();
            }

            else if (rand.NextDouble() <= this.probabilityOfHitting)
            {
                target.IsAlive = false;
                target.getAlive();
            }
            else
            {
                target.getAlive();
            }

        }
    }
}
