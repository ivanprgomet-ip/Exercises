using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class ListSearcher
    {
        public List<string> Search(List<string>allFiles, string searchTerm)
        {
            List<string> filtered = new List<string>();

            foreach(string item in allFiles)
            {
                if(item.ToUpper().Contains(searchTerm.ToUpper()))
                    filtered.Add(item);
            }
            return filtered;
        }
    }
}
