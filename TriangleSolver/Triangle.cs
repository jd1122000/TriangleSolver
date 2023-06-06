using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
    public static class Triangle
    {
        public static string AnalyzeTriangle(int firstSide, int secondSide, int thirdSide)
        {
            string output;
            if ((firstSide == 0) || (secondSide == 0) || (thirdSide == 0))
            {
                output = "Invalid Triangle - at least one side is zero";
                return output;
            }

                if (((firstSide + secondSide) > thirdSide) && ((firstSide + thirdSide) > secondSide) && ((secondSide + thirdSide) > firstSide))
                {
                    if ((firstSide == secondSide) && (firstSide == thirdSide) && (secondSide == thirdSide))
                    {
                        output = "An EQUILATERAL triangle is formed";
                    }
                    else if ((firstSide == secondSide) || (secondSide == thirdSide) || (thirdSide == firstSide))
                    {
                        output = "An ISOSCELES triangle is formed";

                    }
                    else
                    {
                        output = "A SCALENE triangle is formed";

                    }


                }
                else
                {
                    output = "INVALID Triangle detected!!";
                }

            
            return output;
        }
    }
}
