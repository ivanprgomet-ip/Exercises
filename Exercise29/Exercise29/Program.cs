using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise29
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            while(true)
            {
                Console.Clear();
                Console.WriteLine("1/ Create a log");
                Console.WriteLine("2/ Show log");
                string logDecision = Console.ReadLine();
                switch(logDecision)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Log something to file >> ");
                        Console.ResetColor();
                        logger.Log(Console.ReadLine());
                        break;
                    case "2":
                        string log = logger.GetLog();
                        Console.WriteLine(log);
                        Console.ReadKey();
                        break;
                }

                


                
            }


        }
    }
}
