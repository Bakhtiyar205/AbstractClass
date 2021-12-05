using Calculation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SumMultiply
{
    public class Multiply : Archimetric
    {
        public override double Calculation(double n, double m)
        {
            double result = n * m;
            return result;
        }
    }
}
