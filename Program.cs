using System;

namespace MVC_Country_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates CountryController
            CountryController cc = new CountryController();
            //Calls the method for CountryController
            cc.WelcomeAction();
        }
    }
}
