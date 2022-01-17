using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsDay5;

namespace AssignmentsDay5
{
    public class CoinFlip
    {
        public static void FlipCoinPercentage()
        {
            int Headscount = 0;
            int Tailscount = 0;
            Console.WriteLine("Enter the no of turns");
            int numberofTurns = Convert.ToInt32(Console.ReadLine());
            if (numberofTurns > 0)
            {
                for (int i = 0; i < numberofTurns; i++)
                {
                    Random random = new Random();
                    double coin = random.NextDouble();
                    if (coin > 0.5)
                    {
                        Headscount++;
                    }
                    else
                    {
                        Tailscount++;
                    }
                    Console.WriteLine("Heads:" + Headscount + "and" + "Tails:" + Tailscount);
                    double headPercentage = (((double)Headscount / numberofTurns) * 100);
                    double tailPercentage = (((double)Tailscount / numberofTurns) * 100);
                    Console.WriteLine("Head Percentage is:" + headPercentage + "%");
                    Console.WriteLine("Tail Percentage is:" + tailPercentage + "%");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Please Type Valid Input");
                Console.ReadKey();
            }

        }
    }
}
