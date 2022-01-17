using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsDay5;

namespace AssignmentsDay5
{
    class PrimeFactorOfNumbers
    {

        int Factor;
        int Number;

        public PrimeFactorOfNumbers(int NUMBER)
        {
            this.Number = NUMBER;
        }

        public void PrimeFactors()
        {


            for (Factor = 2; Number > 1; Factor++)  
                if (Number % Factor == 0)
                {
                    int Times = 0;
                    while (Number % Factor == 0) 
                    {
                        Number = Number / Factor;
                        Times++; 
                    }
                     Console.WriteLine(Factor + " is a prime factor " + Times + " times! ");
                }
            
        } 

    }
}
