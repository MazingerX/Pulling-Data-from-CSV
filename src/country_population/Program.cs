using System;
using System.Collections.Generic;

namespace country_population
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"‎⁨/Users/luishinostroza/CSharpPractice/Collections/Country_Population/src/country_population/Pop by Largest Final.csv.";
            CsvReader reader = new CsvReader(filepath);

            List<Country> countries = reader.ReadAllCountries();
            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            int lilliputIndex = countries.FindIndex(countries=>x.Population < 2_000_000);
            
            countries.Insert(lilliputIndex, lilliput);   // Insert items in a list

            countries.RemoveAt(lilliputIndex);    // Remove items from a list

            foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation (country.Population).PadLeft(15)}: {country.Name}");
            }

            Console.WriteLine($"{countries.Count} countries");

        }
    }
}
