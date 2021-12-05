using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionHierarchy
{
    public abstract class CourseInformation : Abstraction
    {

        public virtual void RegistrationFee()
        {
            Console.WriteLine("Registration fee is 30 manat ");
        }
    }
}
