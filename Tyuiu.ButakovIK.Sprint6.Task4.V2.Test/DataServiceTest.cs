using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint6.Task4.V2.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] valueWaitArray = new double[stopValue - startValue + 1];

            valueWaitArray[0] = 59.49;
            valueWaitArray[1] = 38.47;
            valueWaitArray[2] = -2.81;
            valueWaitArray[3] = -19.67;
            valueWaitArray[4] = -8.42;
            valueWaitArray[5] = 0.57;                      
            valueWaitArray[6] = -6.3;
            valueWaitArray[7] = -20.14;
            valueWaitArray[8] = -3.51;
            valueWaitArray[9] = 38.13;
            valueWaitArray[10] = 59.6;

            double[] res = new double[stopValue - startValue + 1];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
