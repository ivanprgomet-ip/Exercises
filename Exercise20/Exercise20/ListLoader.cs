using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise20
{
    /// <summary>
    /// class responsible for loading
    /// data into a list.
    /// </summary>
    class ListLoader
    {
        //input list is ref type, no need to return
        public void LoadFilesInto(List<string>input)
        {
            StreamReader reader = new StreamReader("languages.txt");

            //temp string variable to use in while:
            string line;
            
            while((line=reader.ReadLine())!= null)
            {
                input.Add(line); //adding every line to the input list?
            }

            reader.Close();
        }
    }
}
