// See https://aka.ms/new-console-template for more information
using System;

namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user how many people are being fed
            bool startOver = true;

            while (startOver)
            {
                Console.WriteLine("How many people are making PB&J Sandwiches?");
                var amountOfPeople = int.Parse(Console.ReadLine());

                if (amountOfPeople >= 1)
                {
                    // Ingredients & calculations
                    var slicesPerLoaf = 28; // Number of slices in a loaf of bread
                    float totalSlicesNeeded = 2 * amountOfPeople;
                    double totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / slicesPerLoaf);
 
                    var jarPB = 32; // amount tablespoons in 1 jar, but 2 tbsps are needed
                    float tableSpoons = 2 * amountOfPeople;
                    double totalJarPBNeeded = Math.Ceiling(tableSpoons / jarPB);

                    var jarJelly = 48; // teaspoons but 4 tsps are needed
                    float teaSpoons = 4 * amountOfPeople;
                    double totalJarJellyNeeded = Math.Ceiling(teaSpoons / jarJelly);

                    Console.WriteLine($"You need:\n \n {totalSlicesNeeded} slices of bread\n {tableSpoons} tablespoons of peanut butter\n {teaSpoons} teaspoons of jelly\n \nwhich is...\n \n" +
                        $" {totalLoavesNeeded} loaves of bread\n {totalJarPBNeeded} jars of peanut butter\n {totalJarJellyNeeded} jars of jelly ");
                    Console.WriteLine("\n Would you like to star over?\n Yes or No?\n");
                    var input = Console.ReadLine();
                    if (input == "yes" || input == "Yes" || input == "y" || input == "Y")
                    {
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nGoodbye");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered something other than a number or a number less than 0\n Please try again");
                    continue;
                }
            }
        }
    }
}