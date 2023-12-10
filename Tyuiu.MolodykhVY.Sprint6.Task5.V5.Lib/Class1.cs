﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
//
namespace Tyuiu.MolodykhVY.Sprint6.Task5.V5.Lib
{
    public class DataService : ISprint6Task5V5
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] num = new double[len];
            int r = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    num[r] = Convert.ToDouble(line);
                    r++;
                }
            }
            num = num.Where(val => val != 0).ToArray();
            return num;
        }
    }
}
