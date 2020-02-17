using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Country_Lab
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public void Display()
        {
            //To be honest, this Lab feels really confusing because names are so similar.
            //Why have two Classes that are one word apart, and both with a Display method.
            //I bring this up because I keep getting confused about what the jobs of the classes are meant to be constantly.

            //I made a second list of the names because it works, but I think I need to only have ONE CountryDb list with everything in it.
            Countries = new List<Country>();
            Countries.Add(new Country()
            {
                Name = "USA"
            });
            Countries.Add(new Country()
            {
                Name = "Canada"
            });
            Countries.Add(new Country()
            {
                Name = "Mexico"
            });

            //Basic for loop to make the countries be named.
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"Index: {i} || Name: {Countries[i].Name}");
            }
        }
    }
}
