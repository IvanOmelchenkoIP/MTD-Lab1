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
            double[] roots = new double[2];

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
            while(count < 3)
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

            foreach (double coefficient in coefficients) Console.WriteLine("{0}", coefficient);

            return coefficients;
        }
    }
}
