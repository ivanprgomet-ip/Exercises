using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> files = new List<string>();

            ListLoader loader = new ListLoader();
            ListSearcher searcher = new ListSearcher();

            loader.LoadFilesInto(files);

            Console.WriteLine("Please enter a search term: ");
            string searchWord = Console.ReadLine();

            var filtered = searcher.Search(files,searchWord);

            Console.WriteLine($"results of search \"{searchWord}\"");
            foreach(string item in filtered)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //in these types of searches use case-insensitive tactics!
        }
    }
}
