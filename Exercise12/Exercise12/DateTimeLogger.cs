using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class DateTimeLogger : ILogger
    {
        //nullreferenceexception if this list doesnt get new'd:
        public List<string> LogPosts { get; set; } = new List<string>();

        public void Log(string message)
        {
            DateTime current = DateTime.Now;
            message = message +" | saved: "+current;
            LogPosts.Add(message);
        }
    }
}
