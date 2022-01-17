using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsDay5;

namespace AssignmentsDay5
{
    class HarmonicPoblem
    {
        double n;
        double value = 0;
        public HarmonicPoblem(double N)
        {
            this.n = N;
        }

        public void HarmonicSeries()
        {
            for (int i = 0; i <= n; i++) 
            {
                double Value = value + 1 / (float)i;
                
            }
            Console.WriteLine(value);

            Console.WriteLine("Sum of n Numbher of Hrmonic series is "+ value);

        }
    }
}
