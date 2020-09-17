using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, location;

            name = "Alec Willits";
            location = "Seattle, Washington";

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);

            Console.WriteLine("Press any key to exit");

            Console.ReadKey();

        }
    }
}
