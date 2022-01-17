using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsDay5;

namespace AssignmentsDay5
{
    class EvenOrOdd
    {
        int Number;
        string result;
        public EvenOrOdd(int NUMBER)
        {
            this.Number = NUMBER;
        }

        public string Check()
        {
            if ( Number % 2 == 0)
            {
                return result = "this is Even Number";
            }
            else
            {
                return result = "This is Odd Number";
            }
        }
    }
}
