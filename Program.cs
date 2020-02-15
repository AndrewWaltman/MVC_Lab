using System;

namespace MVC_Country_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController c = new CountryController();
            c.WelcomeAction();
        }
    }
}
