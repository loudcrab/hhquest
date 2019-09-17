using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hhQuest
{
    public class Program
    {
        static void Main(string[] args)
        {
            start();
        }
        static void choose(string figure)
        {
            switch (figure)
            {
                case "circle":
                    circleSquare();
                    start();
                    break;
                default:
                    Console.WriteLine("No figure found, enter data again");
                    start();
                    break;
            }

        }
        static void start()
        {
            Console.WriteLine("Choose figure \n circle");
            string figure = Console.ReadLine();
            choose(figure);
        }
        static void circleSquare()
        {
            double square, a, b, c, radius;
            bool isRectangularBool = false;
            string isRectangularString = "No!";
            Console.WriteLine("Enter radius");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the side of triangle A");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the side of triangle A");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the side of triangle A");
            c = Convert.ToDouble(Console.ReadLine());


            circleSquare circleSquare = new circleSquare();
            square = circleSquare.circle(a, b, c, radius);
            isRectangular isRectangular = new isRectangular();

            isRectangularBool = isRectangular.isRectangularBool(a, b, c);
            if (isRectangularBool) isRectangularString = "Yes!";
            Console.WriteLine("The area of ​​the circle is " + square + ". Is the triangle rectangular ? " + isRectangularString);
        }

    }
}
