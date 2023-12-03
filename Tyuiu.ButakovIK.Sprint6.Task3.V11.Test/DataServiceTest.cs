using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tyuiu.ButakovIK.Sprint6.Task3.V11.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] test_matrix = new int[5,5]
                {{27,-15,14,2,27},
                    {-8,14,-10,33,0},
                    {1,7,-11,-11,23},
                    {-13,-20,15,-16,34},
                    { -3,1,-1,5,1}};

            var output_matrix = ds.Calculate(test_matrix);

            int[,] expected_matrix = new int[5, 5]
                {{-13,-15,14,2,27},
                    {-8,14,-10,33,0},
                    {-3,7,-11,-11,23},
                    {1,-20,15,-16,34},
                    {27,1,-1,5,1}};

            CollectionAssert.AreEqual(expected_matrix, output_matrix);
        }
    }
}
