using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC Weather CALCULATOR ***");

            //declair var
            string input;
            int Temperature;
            int dewpoint;
            int relHumidity;
            int windspeed;
           


            //ask user for temperature
            Console.WriteLine("Enter the Temperature");
            input = Console.ReadLine();
            Temperature = int.Parse(input);

            //ask for rel humidity
            Console.WriteLine("Enter Relative Humidity");
            input = Console.ReadLine();
            relHumidity = int.Parse(input);

            //calc dewpoint
            dewpoint = Temperature - 9 * (100 - relHumidity) / 25;

            //print dewpoint
            Console.WriteLine("Dew Point =" + dewpoint);

            //ask for windspeed
            Console.WriteLine("Enter the Wind Speed");
            input = Console.ReadLine();
            windspeed = int.Parse(input);

            //calculate the wind chill
            double windchill = 35.74
                + (.6215 * Temperature)
                - (35.75 * Math.Pow(windspeed, .16))
                + (.4275 * Temperature * Math.Pow(windspeed, .16));


            //print the windchill
            Console.WriteLine("Wind Chill =" + windchill);

        }
    }
}
