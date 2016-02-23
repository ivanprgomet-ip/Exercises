using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger myLogger = new Logger();
            myLogger.Log("log1: hello my name is ivan");
            myLogger.Log("log2: this is log 2");

            foreach(string l1 in myLogger.LogPosts)//foreach to iterate
            {
                Console.WriteLine(l1);
            }

            myLogger.LogPosts.ForEach(x => Console.WriteLine(x));//lambda expression to iterate 
        }
    }
}
