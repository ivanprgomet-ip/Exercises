using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class ListLoader
    {
        public List<LanguageData> LoadData()
        {
            List<LanguageData> result = new List<LanguageData>();
            StreamReader reader = new StreamReader("languageData.txt");

            string line = "";


            while ((line = reader.ReadLine()) != null)
            {
                var name = line.Split('\t')[0];//splits at the tabs in the file, creates an array of strings, and then takes the first index
                var year = int.Parse(line.Split('\t')[1]);//splits at the tabs in the file, creates an array of strings, and then takes the second index
                var description = line.Split('\t')[2];//splits at the tabs in the file, creates an array of strings, and then takes the third index

                var langData = new LanguageData
                {
                    Description = description,
                    Name = name,
                    Year = year
                };
                result.Add(langData);
            }

            reader.Close();
            return result;
        }

        public void SaveToFile(List<LanguageData>files)
        {
            StreamWriter writer = new StreamWriter("filtered.txt");

            foreach (var item in files.OrderBy(x => x.Year))//TODO study linq/lambda
            {
                writer.WriteLine($"{item.Name}-{item.Year} ({item.Description})");
            }
            writer.Close();
        }
    }
}
