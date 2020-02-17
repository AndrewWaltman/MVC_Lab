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

            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"Index: {i} || Name: {Countries[i].Name}");
            }
        }
    }
}
