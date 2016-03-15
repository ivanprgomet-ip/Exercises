using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            ArrayList arrLst = new ArrayList();

            sw.Start();
            for (int i = 0; i < 10000000; i++)
            {
                arrLst.Add(i);
            }
            sw.Stop();

            Console.WriteLine("Array list:" + sw.ElapsedMilliseconds + "miliseconds");
            sw.Reset();

            List<int> myList = new List<int>();

            sw.Start();
            for (int i = 0; i < 10000000; i++)
            {
                myList.Add(i);
            }
            sw.Stop();

            Console.WriteLine("Generic list:" + sw.ElapsedMilliseconds + "miliseconds");
            sw.Reset();



        }
    }
}
