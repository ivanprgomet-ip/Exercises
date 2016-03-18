using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(5, 5));
            Console.WriteLine(Calculator.Subtract(15, 10));

            Console.WriteLine("memory before: " + Calculator.Memory);
            Calculator.Add(20);
            Calculator.Add(10);
            Calculator.Subtract(5);
            Calculator.Subtract(10);
            Console.WriteLine("memory after: " + Calculator.Memory);
        }
    }
}
