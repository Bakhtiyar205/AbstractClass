using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionHierarchy
{
    public class InEnglish : CourseInformation
    {
        public override void Courses()
        {
            int monthly=50;
            int total = monthly * 6;
            Console.WriteLine("The price is "+monthly+" in a month." +total+" is whole price of course in English");


        }

        public override void RegistrationFee()
        {
            Console.WriteLine("Registration fee is 40 mant"); ;
        }
    }
}
