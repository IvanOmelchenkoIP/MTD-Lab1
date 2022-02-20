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

            double[] coefficients = sc.GetCoefficients();
            DisplayEquation(coefficients);

            double[] roots = sc.CountRoots();

            Console.ReadKey();
        }

        private static void DisplayEquation(double[] coefficients)
        {
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

        }
    }
}
