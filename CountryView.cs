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
            Console.WriteLine($"Name: {c.Name}");
            Console.WriteLine($"Continent: {c.Continent}");
            Console.WriteLine($"Color: {c.Colors}");
        }
    }
}
