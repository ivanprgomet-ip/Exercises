using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20v2
{
    class Filter
    {
        public List<string> Search(List<string>inputList, string search)
        {
            List<string> result = new List<string>();

            foreach(string item in inputList)
            {
                if (item.ToUpper().Contains(search.ToUpper()))//case-insensitive
                    result.Add(item);
            }

            return result;
        }

    }
}
