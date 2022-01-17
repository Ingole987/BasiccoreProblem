using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsDay5;

namespace AssignmentsDay5
{
    class CalculateLargest

    {   
        //Fields
        int Num1, Num2, Num3;
        
        //COnstructor
        public CalculateLargest(int NUMBER1, int NUMBER2, int NUMBER3)
        {
            this.Num1 = NUMBER1;
            this.Num2 = NUMBER2;
            this.Num3 = NUMBER3;
        }

        public void Largest()
        {
            if (Num1 > Num2)
            {
               if (Num1 > Num3)
                {
                    
                    Console.WriteLine(Num1 + " is Largest amoung all");
                }
               else
                {
                    Console.WriteLine(Num3 + " is Largest amoung all");

                }
            }
            else if (Num2 > Num1)
            {
                if (Num2 > Num3)
                {

                    Console.WriteLine(Num2 + " is Largest amoung all");
                }
                else
                {
                    Console.WriteLine(Num3 + " is Largest amoung all");

                }

            }
            else if (Num3 > Num1)
            {
                if (Num3 > Num2)
                {

                    Console.WriteLine(Num3 + " is Largest amoung all");
                }
                else
                {
                    Console.WriteLine(Num2 + " is Largest amoung all");

                }
            }

            else
            {
                Console.WriteLine("All 3 Numbers are Same");
            }
        }



        //C# Program to Find the Largest Among Three Numbers
    }
}
