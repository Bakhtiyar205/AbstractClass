using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionHierarchy
{
    public class InRussian : CourseInformation
    {
        public override void Courses()
        {
            int monthly = 40;
            int total = monthly * 6;
            Console.WriteLine("Price is "+monthly+" in a month. "+total+" is total price in Russian.");
        }

        public override void RegistrationFee()
        {
            base.RegistrationFee();
        }
    }
}
