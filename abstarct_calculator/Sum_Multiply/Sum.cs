using Calculation;

namespace SumMultiply
{
    public class Sum : Archimetric
    {
        public override decimal Calculation(int n, int m)
        {
            decimal result = n + m;
            return result;
        }
    }
}
