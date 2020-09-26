using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static object now;

        static void Main(string[] args)
        {
            string name = string.Empty;
            string location = string.Empty;

            Console.Write("Please enter your full name: ");
            name = Console.ReadLine();

            Console.Write("Where are you from? ");
            location = Console.ReadLine();

            Console.Write($"Your name is {name} You are from {location}");

            Console.WriteLine("");

            var currentDate = DateTime.Now;


            //find remaining days
            var nextChristmas = new DateTime(currentDate.year, 12, 25);
            var dateDiff = nextChristmas - currentDate; 
          

            //Console.WriteLine("{0} was {1} days ago", someDate, daysAgo.ToString("0"));


            //Come from 2.1

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please Enter width in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //processing
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);


            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
