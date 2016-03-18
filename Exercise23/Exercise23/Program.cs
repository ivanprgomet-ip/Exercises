using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise A
            Checkbox c = new Checkbox();
            Console.WriteLine(c.GetDescription());
            c.Click();
            Console.WriteLine(c.GetDescription());
            c.Click();
            Console.WriteLine(c.GetDescription());

            //Exercise B
            Coordinate? c1 = new Coordinate { x = 2, y = 4 };
            Coordinate? c2 = new Coordinate { x = 4, y = 8 };
            Coordinate? c3 = new Coordinate { x = 5, y = 10 };

            //only instantiates triangle if the cords have values
            Triangle triangle = null;//compiler getting mad if not assigning any value
            if(c1.HasValue && c2.HasValue && c3.HasValue)
            {
                triangle = new Triangle(c1.Value, c2.Value, c3.Value);//.value contains the un-nullable type
            }
            

        }
    }
}
