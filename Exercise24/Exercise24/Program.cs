using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = new Weight();
            weight.Add(WeightUnit.Kilogram, 2.0);
            weight.Add(WeightUnit.Pound, 1.0);

            //this line should print 2.453592
            Console.WriteLine(weight.GetWeight(WeightUnit.Kilogram));//gets whatever weight in kilograms
            //this line should print 5.40924
            Console.WriteLine(weight.GetWeight(WeightUnit.Pound));//gets whatever weight in pounds

        }
    }
}
