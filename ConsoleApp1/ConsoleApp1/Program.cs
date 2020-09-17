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
        static void Main(string[] args)
        {
            string name = string.Empty;
            string location = string.Empty;

            Console.WriteLine("Please enter your full name");
            name = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            location = Console.ReadLine();

            Console.WriteLine($"Your name is {name} You are from {location}");

            var currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToShortDateString());

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
