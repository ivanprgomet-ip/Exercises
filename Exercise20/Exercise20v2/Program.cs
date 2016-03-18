using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20v2
{
    class Program
    {
        static void Main(string[] args)
        {

            ListLoader loader = new ListLoader();
            var myList = loader.Load();

            Console.Write("enter search: ");
            string term = Console.ReadLine();

            var filter = new Filter();
            var myFilteredList= filter.Search(myList, term);

            foreach(var item in myFilteredList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
