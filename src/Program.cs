using System;

namespace MTD_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareCounter sc;
            if (args.Length > 0) sc = new FileCounter();
            else sc = new InterractiveCounter();

            sc.GetCoefficients();


            Console.ReadKey();
        }

        private static void DisplayEquation(double[] coefficients)
        {

        }

        private static void DisplayResults(double[] roots)
        {

        }
    }
}
