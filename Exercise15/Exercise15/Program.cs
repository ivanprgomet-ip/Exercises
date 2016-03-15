using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter sentence or word");
            string input = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            //count individual characters
            #region 2 alternatives
            //Console.WriteLine("ALT 1:");
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //int counter = 1;
            //foreach (char c in input)
            //{
            //    if (dict.ContainsKey(c.ToString()))
            //        dict[c.ToString()] = counter++;
            //    else
            //        dict.Add(c.ToString(), 1);
            //}

            //foreach (var kvp in dict)
            //{
            //    Console.WriteLine(kvp.Key + ": " + kvp.Value);
            //}

            Console.WriteLine("ALT 2:");
            Dictionary<string, string> dict2 = new Dictionary<string, string>();
            foreach (char c in input)
            {
                if (dict2.ContainsKey(c.ToString()))
                    dict2[c.ToString()] += "*";
                else
                    dict2.Add(c.ToString(), "*");
            }
            foreach (var kvp in dict2)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
            #endregion



            Console.ForegroundColor = ConsoleColor.Yellow;
            //count individual words
            string[] w = input.Split(' ');

            var words = new Dictionary<string, string>();
            foreach (var word in w)
            {
                if (words.ContainsKey(word.ToString()))
                    words[word.ToString()] += "*";
                else
                    words.Add(word.ToString(), "*");
            }
            foreach (var word in words)
            {
                Console.WriteLine(word.Key + ": " + word.Value);
            }


            Console.ResetColor();
        }

        
    }
}
