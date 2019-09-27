using System;

namespace country_population
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"‎⁨/Users/luishinostroza/CSharpPractice/Collections/Country_Population/src/country_population/Pop by Largest Final.csv.";
            CsvReader reader = new CsvReader(filepath);

            Country[] countries = reader.ReadFirstCountries(10);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation (country.Population).PadLeft(15)}: {country.Name}");
            }

        }
    }
}
