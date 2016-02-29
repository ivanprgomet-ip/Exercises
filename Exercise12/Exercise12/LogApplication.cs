using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    /// <summary>
    /// this class is mainly consisting the menu and Gui choices 
    /// </summary>
    class LogApplication
    {
        ILogger _Ilogger { get; set; }
        public LogApplication(ILogger ilogger)
        {
            /*the _ilogger variable gets set
            from the outside only, if there
            wasnt anything connecting this._ilogger
            with the ilogger in the constructor 
            parameter there would be a nullexception*/
            _Ilogger = ilogger;
        }
        public void Run()
        {
            Console.WriteLine("1) Add message to log");//the log method gets called on the ILogger!
            Console.WriteLine("2) Print log");//the logposts property gets called on the ILogger!
            Console.WriteLine();
            Console.Write("Choice >> ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Console.Write("Log >> ");
                    string logMsg = Console.ReadLine();
                    /*which Log method gets used at this stage is still 
                    unclear depending on which class instance 
                    gets put in the constructor of 
                    the LogApplication instance...
                    the class instance has to be inheriting 
                    from the ILogger interface to be accepted 
                    by the constructor parameter in main method*/
                    _Ilogger.Log(logMsg);

                    Console.Clear();
                    break;
                case "2":
                    foreach(string s in _Ilogger.LogPosts)
                    {
                        Console.WriteLine(s);
                    }

                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("invalid input");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }
    }
}
