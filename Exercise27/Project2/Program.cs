using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*only calculator 2 is avaliable in this project because its public.
            calculator 1 is not avaliable because its internal, and only visible
            within the own project. 
            
            only the add method from calculator2 is avaliable, because its public.
            the subtract is private and only avaliable within the same class,
            and the multiply method defaults to */
            Exercise27.Calculator2 calc2 = new Exercise27.Calculator2();
            calc2.Add(5, 10);
            
        }
    }
}
