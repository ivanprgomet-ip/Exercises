using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            #region users current age
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Year of birth (yyyy): ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month of birth (mm): ");
            int month= int.Parse(Console.ReadLine());
            Console.Write("Day of birth (dd): ");
            int day= int.Parse(Console.ReadLine());

            DateTime bornDate = new DateTime(year, month, day);//USER WAS BORN ON THIS DATE
            DateTime currentDate = DateTime.Today;//DATE OF TODAY
            int age = currentDate.Year - bornDate.Year;//AGE IN DIGIT eg. 23
            DateTime mostRecentBday = bornDate.AddYears(age);//DATE BORN + AGE IN DIGIT = THE LATEST BIRTHDAY CELEBRATED (already passed!)

            //IF THE CURRENT DATE IS SMALLER THAN 
            //THE DATE OF THE LATEST BIRTHDAY THATS 
            //PASSED, AGE IS ONE LESS
            if (currentDate < mostRecentBday)
                age--;

            Console.WriteLine($"{name}, you are {age} years old");
            #endregion

            #region user turns age+1 in:
            TimeSpan timeUntilNextBday = mostRecentBday - currentDate;
            int daysUntilNextBday = 0;

            if (timeUntilNextBday.Days < 0)
                daysUntilNextBday = timeUntilNextBday.Days + 365;
            else
                daysUntilNextBday = timeUntilNextBday.Days;

            Console.WriteLine($"you will turn {age+1} in {daysUntilNextBday} days");
            #endregion

            #region 100th birthday
            DateTime myHundreth = new DateTime(year+100,month,day);
            Console.WriteLine($"Your 100th birthday will be on a {myHundreth.DayOfWeek}");
            Console.ReadKey();
            #endregion
        }
    }
}
