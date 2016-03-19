using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise30
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather forecast = new Weather();

            Console.WriteLine("Enter mm: ");
            int inMonth= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DD: ");
            int inDay = int.Parse(Console.ReadLine());
            DateTime inputDate = new DateTime(DateTime.Now.Year, inMonth, inDay);

            /*To access enum weather type, 
            must go via weather class*/
            Weather.Type forecastResults = forecast.Forecast(inputDate);
            Console.WriteLine($"Forecast results: {forecastResults}");
        }
    }
}
