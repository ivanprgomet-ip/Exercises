using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise29
{
    interface ILogger
    {
        void Log(string msg);
        string GetLog();//loads logs from textfile

    }
}
