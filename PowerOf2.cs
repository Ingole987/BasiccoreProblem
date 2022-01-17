using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsDay5;

namespace AssignmentsDay5
{
    class TableOfPowerOf2
    {
        int n;
        int result;
        public TableOfPowerOf2( int N )
        {
            this.n = N;

        }
            
       public void TableOf2()
        {
          for (int i = 1; i < n ;i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
         


    }
}
