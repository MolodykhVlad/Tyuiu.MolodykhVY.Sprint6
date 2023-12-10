using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolodykhVY.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string str, string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] lastStr = line.Split(' ');
                    for (int i = 0; i < lastStr.Length; i++)
                    {
                        if (lastStr[i].Contains(str))
                        {
                            res += " " + lastStr[i];
                        }
                    }
                }
            }
            return res;
        }
    }
}
