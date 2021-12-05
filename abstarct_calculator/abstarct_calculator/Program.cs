using SumMultiply;
using System;

namespace AbstarctCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter first number");
            var n = 10;   /*Convert.ToInt32(Console.ReadLine());*/
            //Console.WriteLine("Enter second number");
            var m = -20;  /*Convert.ToInt32(Console.ReadLine());*/
     
            if(n>0 && m > 0)
            {
                Multiply mlt = new Multiply();
                var mltResult = mlt.Calculation(n, m);
                Console.WriteLine("Multipication: " + mltResult);

                Division dv = new Division();
                var dvResult = dv.Calculation(n, m);
                Console.WriteLine("Division: " + dvResult);

                Substraction sbs = new Substraction();
                var sbsResult = sbs.Calculation(n, m);
                Console.WriteLine("Substraction: " + sbsResult);

                Sum sum = new Sum();
                var sumResult = sum.Calculation(n, m);
                Console.WriteLine("Sum " + sumResult);
            }
            else
            {
                Console.WriteLine("Enter Positive Numbers");
            }

        }
    }
}
