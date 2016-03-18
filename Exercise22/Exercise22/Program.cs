using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Coordinate first = new Coordinate();
            first.x = 5;
            first.y = 10;

            Coordinate second = first; 

            second.x = 2;
            second.y = 4;

            Console.WriteLine($"First: x:{first.x} y:{first.y}");
            Console.WriteLine($"second: x:{second.x} y:{second.y}");
            Console.WriteLine("* Structures are value types\nsecond struct instance is a copy of first struct instance");
            Console.WriteLine();


            //same example with class instance
            Console.ForegroundColor = ConsoleColor.Cyan;
            coord first2 = new coord();
            first2.x = 5;
            first2.y = 10;

            coord second2 = first2;

            second2.x = 2;
            second2.y = 4;

            Console.WriteLine($"First: x:{first2.x} y:{first2.y}");
            Console.WriteLine($"second: x:{second2.x} y:{second2.y}");
            Console.WriteLine("* Classes are reference types\nsecond instance using the same mem space as first instance");
            Console.ResetColor();
            Console.ReadKey();



        }
    }
}
