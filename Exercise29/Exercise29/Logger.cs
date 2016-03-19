using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise29
{
    class Logger : ILogger
    {
        /*the only thing associating the methods is that they both 
        use the same externa log file (log.txt). one writes to the 
        file and the other returns a string containing all the 
        logs from the file.*/
        public string GetLog()
        {
            /*creating an instance of streamreader to read from a file*/
            StreamReader reader = new StreamReader("log.txt");

            /*where we will store all the logs*/
            string allData = string.Empty;


            /*
            using keyword guarantes that the reader gets closed
            when its not in use anymore.
            */
            using (reader)
            {
                /*
                we create a variable that will store each read line. 
                With its creation, we directly read the first line of 
                text file. If the text file is empty, the method ReadLine() 
                of the StreamReader object will return null
                */
                string line = reader.ReadLine();

                /*
                while allData is not null we will loop this and 
                read from the LOG.TXT. remember first line is not
                null due to reading the firs line before the loop.
                in short: as long as there is something in the variable 
                line, we should continue reading
                */
                while (line != null)
                {
                    /*
                    we use ReadLine() to read the next line in the file 
                    and write it in the variable line.
                    the line variable is NOT concatinating what the 
                    reader reads. its only temporarily storing on a line
                    per line basis for every iteraion. we store ALL the 
                    lines in the allData variable because this is the variable
                    that the method will be returning, the bearer of all the 
                    log posts.
                    */
                    line = reader.ReadLine();
                    /*
                    adding/concatinating on new lines to previous ones. the \n is 
                    just so that the returned string has new lines in it, so that 
                    everything isnt concatinated into one long string.
                    */
                    allData = allData + line + "\n";
                }                return allData;
            }
        }

        public void Log(string msg)
        {
            //true: append new lines instead of overwriting old lines of text
            StreamWriter writer = new StreamWriter("log.txt",true);

            /*
            using keyword guarantes that the writer gets 
            closed when its not in use anymore.
            */
            using (writer)
            {
                writer.WriteLine(msg);
            }
        }
    }
}
