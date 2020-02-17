using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Country_Lab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }
        
        public void Display(Country c)
        {
            //I THINK this would be right, but I'm not sure.

            DisplayCountry = new Country();

            Console.WriteLine("Name: " + c.Name);
            Console.WriteLine("Continent: " + c.Continent);
            Console.WriteLine("Colors: " + c.Colors);
        }
    }
}
