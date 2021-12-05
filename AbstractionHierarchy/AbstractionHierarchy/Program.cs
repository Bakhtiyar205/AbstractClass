using System;

namespace AbstractionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            InEnglish english = new InEnglish();
            english.Courses();
            english.RegistrationFee();


            InRussian russian = new InRussian();
            russian.Courses();
            russian.RegistrationFee();
        }
    }
}
