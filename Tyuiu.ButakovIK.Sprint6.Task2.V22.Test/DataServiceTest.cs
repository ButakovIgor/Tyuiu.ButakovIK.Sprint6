using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint6.Task2.V22.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task2.V22.Test
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

            valueWaitArray[0] = 7.76;
            valueWaitArray[1] = 7.36;
            valueWaitArray[2] = 7.26;
            valueWaitArray[3] = 7.9;
            valueWaitArray[4] = 15.88;
            valueWaitArray[5] = 2;
            valueWaitArray[6] = 4.35;
            valueWaitArray[7] = 5.63;
            valueWaitArray[8] = 6.49;
            valueWaitArray[9] = 6.49;
            valueWaitArray[10] = 6.32;

            double[] res = new double[stopValue - startValue + 1];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
