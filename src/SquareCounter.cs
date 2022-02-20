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
            return coefficients;
        }
    }
}
