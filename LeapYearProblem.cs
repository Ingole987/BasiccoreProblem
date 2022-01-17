using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentsDay5;

namespace AssignmentsDay5
{
    class LeapYearProblem
    {
        int YearToRead;
        public LeapYearProblem( int YEARTOREAD)
        {
            this.YearToRead = YEARTOREAD;
            int YearToRead = YEARTOREAD;
        }
        public string MethodToCheckLeapYear()
        {
            int remainder1 = YearToCheck % 400;
            string YesItIs = " is leap year";

            if (remainder1 == 0)
            {
                return YesItIs;
            }
            else
            {
                int remainder2 = YearToRead % 4;
                if (remainder2 == 0)
                {
                    
                return YesItIs;
                }
                else
                {
                    string NoItIsNot = " is not Leap Year";
                return NoItIsNot;
                }
            }
        }
    }
}
