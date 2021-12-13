using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int winsA = 0;
            int winsB = 0;
            int winsC = 0;
            int i = 0;

            Duelist aaron = new Duelist("Aaron", (1.0 / 3.0));
            Duelist bob = new Duelist("Bob", (1.0 / 2.0));
            Duelist charlie = new Duelist("Charlie", 1.0);

            while (i != 1000)
            {
                if (aaron.IsAlive == true)
                {

                    if (charlie.IsAlive == true)
                    {
                        aaron.shootAtTarget(charlie);
                    }
                    else if (bob.IsAlive == true)
                    {
                        aaron.shootAtTarget(bob);
                    }
                    else
                    {
                        winsA++;
                    }

                }
                else if (bob.IsAlive == true)
                {
                    if (charlie.IsAlive == true)
                    {
                        bob.shootAtTarget(charlie);
                    }
                    else if (aaron.IsAlive == true)
                    {
                        bob.shootAtTarget(aaron);
                    }
                    else
                    {
                        winsB++;
                    }
                }
                else
                {
                    if (bob.IsAlive == true)
                    {
                        charlie.shootAtTarget(bob);
                    }
                    else if (aaron.IsAlive == true)
                    {
                        charlie.shootAtTarget(aaron);
                    }
                    else
                    {
                        winsC++;
                    }
                }
                Console.WriteLine(winsA);
                Console.WriteLine(winsB);
                Console.WriteLine(winsC);
                i++;
                Console.ReadLine();

            }

        }
    }
}
