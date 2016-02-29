using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    interface ILogger
    {
        List<string> LogPosts { get; set; }

        /*doesnt say HOW this method will
        be implemented because it will be specific
        for the classes that implement the interface*/
        void Log(string message);



    }
}
