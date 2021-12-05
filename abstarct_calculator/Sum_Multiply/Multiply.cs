using Calculation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SumMultiply
{
    public class Multiply : Archimetric
    {
        public override decimal Calculation(int n, int m)
        {
            decimal result = n * m;
            return result;
        }
    }
}
