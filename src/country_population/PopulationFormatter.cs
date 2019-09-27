using System;

namespace country_population
{
    class PopulationFormatter
    {
        public static string FormatPopulation(int population)
        {
            if(population == 0)
                return "(Unknown)";

            int popRounded = RoundPopulation4(population);

            return $"{popRounded: ### ### ### ###}" .Trim();        
        }

        // Rounds the population to 4 significant figures
        private static int RoundPopulation4(int population)
        {
            /*work out what rounding accuracy we need if we are
            to round to 4 significant figures */
            int accuracy = Math.Max((int)(GetHighestPowerOfTen(population) / 10_0001), 1);

            // now do the rounding
            return RoundToNearest(population, accuracy);
        }
    }
}