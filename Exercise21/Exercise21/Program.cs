using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            ListLoader loader = new ListLoader();
            var myData = loader.LoadData();
            Console.Write("start year: ");
            int startYear = int.Parse(Console.ReadLine());
            Console.Write("end year: ");
            int endYear = int.Parse(Console.ReadLine());


            var filteredResult = new List<LanguageData>();//setting up list where later store filtered result
            foreach (var item in myData)
            {
                if (item.Year >= startYear && item.Year <= endYear)
                    filteredResult.Add(item);
            }

            foreach(var item in filteredResult.OrderBy(x => x.Year))//TODO study linq/lambda
            {
                Console.WriteLine($"{item.Name}\t{item.Year}\t{item.Description}");
            }


            loader.SaveToFile(filteredResult);//writing whatever is on the filteredResult list to file



        }
    }
}
