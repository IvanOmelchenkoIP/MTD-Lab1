using System;
using System.Globalization;
using System.Threading;

namespace MTD_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SquareCounter sc;
            double[] coefficients;
            if (args.Length > 0) 
            { 
                sc = new FileCounter();
                coefficients = sc.GetCoefficients(args[0]);
            }
            else
            {
                sc = new InterractiveCounter();
                coefficients = sc.GetCoefficients();
            }
            DisplayEquation(coefficients);

            double[] roots = sc.CountRoots();
            DisplayResults(roots);

            Console.ReadKey();
        }

        private static void DisplayEquation(double[] coefficients)
        {
            if (coefficients == null || coefficients[0] == 0) return;

            Console.Write("The equation is: ");
            for (int i = 0; i < coefficients.Length; i++)
            {
                double number = coefficients[i];
                if (number == 0) continue;

                string value = number.ToString();
                if (i > 0)
                {
                    if (number > 0) value = "+ " + number;
                    else value = "- " + (-number);
                }

                int rank = (coefficients.Length - 1) - i;
                string param;
                switch (rank)
                {
                    case 0:
                        param = "";
                        break;
                    case 1:
                        param = " * x";
                        break;
                    default:
                        param = " * x^" + rank;
                        break;
                }
                Console.Write("{0}{1} ", value, param);
            }
            Console.Write("= 0\n");
        }

        private static void DisplayResults(double[] roots)
        {
            if (roots == null)
            {
                Console.WriteLine("There are 0 roots");
                return;
            }

            double x1 = roots[0];
            double x2 = roots[1];

            if (x1 == x2)
            {
                Console.WriteLine("There is 1 root:");
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("There are 2 roots:");
                Console.WriteLine("x1 = {0},\nx2 = {1}", x1, x2);
            }
        }
    }
}
