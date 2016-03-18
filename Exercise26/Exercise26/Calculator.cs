using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26
{
    class Calculator
    {
        public static int Memory { get; private set; } 

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static void Add(int a)
        {
            Memory += a;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static void Subtract(int a)
        {
            Memory -= a;
        }
    }
}
