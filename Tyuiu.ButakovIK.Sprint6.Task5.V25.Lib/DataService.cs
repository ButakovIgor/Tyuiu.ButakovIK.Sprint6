using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.ButakovIK.Sprint6.Task5.V25.Lib⁢
{
    public class DataService : ISprint6Task5V25
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

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            numsArray = numsArray.Where(val => val != 0).ToArray();

            for (int i = 0; i < numsArray.Count(); i++)
            {
                numsArray[i] = System.Math.Round(numsArray[i],3);
            }

            return numsArray;
        }
    }
}