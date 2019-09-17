using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhQuest
{
    public class isRectangular
    {
        public bool isRectangularBool(double a, double b, double c)
        {
            bool isRectangularBool = false;
            double a2, b2, c2;
            a2 = Math.Sqrt((b * b + c * c));
            b2 = Math.Sqrt((a * a + c * c));
            c2 = Math.Sqrt((b * b + a * a));
            if ((a == a2) || (b == b2) || (c == c2)) isRectangularBool = true;
            return isRectangularBool;
        }
    }
}
