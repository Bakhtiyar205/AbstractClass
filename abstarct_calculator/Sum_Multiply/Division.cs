using Calculation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SumMultiply
{
    public class Division : Archimetric
    {
        public override decimal Calculation(int n, int m)
        {
            decimal result = n / m;
            return result;
        }
    }
}
