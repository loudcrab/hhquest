using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhQuest
{
    public class circleSquare
    {
        public double circle(double a, double b, double c, double radius)
        {
            double square;
            square = (a * b * c) / (4 * radius);
            return square;
        }
    }
}
