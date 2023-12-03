using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ButakovIK.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int numRows = matrix.GetLength(0); 
            int[] firstColumn = new int[numRows]; 
            for (int i = 0; i < numRows; i++)
            {
                firstColumn[i] = matrix[i, 0];
            }
            Array.Sort(firstColumn);
            for (int i = 0; i < numRows; i++)
            {
                matrix[i, 0] = firstColumn[i];
            }
            return matrix;
        }
    }
}
