using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ButakovIK.Sprint6.Task7.V16.Lib
{
    public class DataService : ISprint6Task7V16
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            string[] lines = file.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int rowsCount = lines.Length;
            int columnsCount = lines[0].Split(';').Length;
            int[,] values = new int[rowsCount, columnsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                string[] lineRows = lines[i].Split(';');
                for (int j = 0; j < columnsCount; j++)
                    values[i, j] = Convert.ToInt32(lineRows[j]);
            }
            for (int i = 0; i < rowsCount; i++)
            {

                for (int j = 0; j < columnsCount; j++)
                    if (i == 4 && values[i,j] % 2 != 0)
                        values[i, j] = -1;
            }
            return values;
        }
    }
}
