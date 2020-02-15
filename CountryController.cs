using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Country_Lab
{
    class CountryController
    {
        public List<Country> CountryDb = new List<Country>();

        public void CountryAction(Country c)
        {
            CountryDb = new List<Country>();
            CountryDb.Add(new Country()
            {
                Name = "United States of America",
                Continent = "North America",
                Colors = {"Red", "White", "Blue"}
            });
            CountryDb.Add(new Country()
            {
                Name = "Canada",
                Continent = "North America",
                Colors = {"Red", "White"}
            });
            CountryDb.Add(new Country()
            {
                Name = "Mexico",
                Continent = "North America",
                Colors = {"Green", "White", "Red"}
            });
        }
        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app.");
            Console.WriteLine("Please select a country from the following list:");
            Console.WriteLine("================================================\n");
            
            string input = Console.ReadLine();

            Continue();
        }
        public void Continue()
        {
            Console.WriteLine("Would you like to learn about another country? \"yes\" or \"no\"");
            string input = Console.ReadLine().ToLower();

            if(input == "yes" || input  == "y")
            {
                Console.Clear();
                WelcomeAction();
            }
            else if(input == "no" || input == "n")
            {
                Console.WriteLine("Thank you.");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Sorry, that was an invalid response, please try again.");
                Continue();
            }
        }
    }
}
