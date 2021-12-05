using Calculation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SumMultiply
{
    public class Substraction : Archimetric
    {
        public override decimal Calculation(int n, int m)
        {
            decimal result = n - m;
            return result;
        }
    }
}
