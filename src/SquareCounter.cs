using System;
using System.Collections.Generic;
using System.Text;

namespace MTD_Lab1
{
    abstract class SquareCounter
    {
        protected double[] coefficients = new double[3];

        public abstract double[] GetCoefficients();

        public double[] CountRoots()
        {
            double a = coefficients[0];
            double b = coefficients[1];
            double c = coefficients[2];

            double x1, x2;

            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                return null;
            }
            else if (D == 0)
            {
                x1 = x2 = -b / 2 * a;
            }
            else
            {
                double sqrtD = Math.Sqrt(D);
                x1 = -b + sqrtD / 2 * a;
                x2 = -b - sqrtD / 2 * a;

            }

            double[] roots = new double[2] {x1, x2 };
            return roots;
        }

    }

    class FileCounter : SquareCounter
    {
        public override double[] GetCoefficients() 
        {
            return coefficients;
        }
    }

    class InterractiveCounter : SquareCounter
    {
        public override double[] GetCoefficients()
        {
            string[] variables = new string[3] { "a", "b", "c" };
            int count = 0;
            while (count < 3)
            {
                Console.Write("Input coefficient {0} (must be real number): ", variables[count]);
                string input = Console.ReadLine();
                
                double number;
                if (double.TryParse(input, out number) == false)
                {
                    Console.WriteLine("Error! Expected a real number, got {0} instead", input);
                    continue;
                }
                if (count == 0 && number == 0)
                {
                    Console.WriteLine("Error! a can`t be 0");
                    continue;
                }

                Console.WriteLine();
                coefficients[count] = number;
                count++;
            }

            return coefficients;
        }
    }
}
