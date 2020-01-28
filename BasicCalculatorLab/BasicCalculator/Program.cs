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


            

            //ask for windspeed

            //calculate the wind chill

            //print the windchill

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



        }
    }
}
