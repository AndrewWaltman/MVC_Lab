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
                Name = "USA",
                Continent = "North America",
                Colors = { "Red", "White", "Blue" }
            });
            CountryDb.Add(new Country()
            {
                Name = "Canada",
                Continent = "North America",
                Colors = { "Red", "White" }
            });
            CountryDb.Add(new Country()
            {
                Name = "Mexico",
                Continent = "North America",
                Colors = { "Red", "White", "Green" }
            });



            //When I try to draw from the CountryDb list, I run into an error.
            //System.NullReferenceException : Object not sent to an instance of an object.
            //I don't really know what it means, let alone how to fix this issue.
        }
        public void WelcomeAction()
        {
            Country c = new Country();
            CountryListView clv = new CountryListView();
            CountryView cv = new CountryView();

            Console.WriteLine("Hello! Welcome to the Country App.");
            Console.WriteLine("Please select a country by index from the following list:");
            Console.WriteLine("=========================================================");
            clv.Display();
            Console.WriteLine("=========================================================");

            string select = Console.ReadLine().Trim();

            if (select == "0")
            {


                //Console.WriteLine("Name: USA");
                //Console.WriteLine("Continent: North America");
                //Console.WriteLine("Colors: Red, White, Blue");
            }
            else if(select == "1")
            {
                Console.WriteLine("Name: Canada");
                Console.WriteLine("Continent: North America");
                Console.WriteLine("Colors: Red, White");
            }
            else if(select == "2")
            {
                Console.WriteLine("Name: Mexico");
                Console.WriteLine("Continent: North America");
                Console.WriteLine("Colors: Red, White, Green");
            }
            else
            {
                Console.WriteLine("Invalid repsonse, please try again.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                WelcomeAction();
            }
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
