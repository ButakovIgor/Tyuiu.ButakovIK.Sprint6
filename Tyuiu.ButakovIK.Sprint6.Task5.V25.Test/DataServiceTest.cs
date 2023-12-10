using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ButakovIK.Sprint6.Task5.V25.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValidExistsFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask5V25.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V25.txt";
            double[] testOutput = { -17, 12, -14.32, 5, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, 35, -9, 13.83, 12.76, 8.86, -1.49, -7 };
            double[] output = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(testOutput, output);
        }
    }
}
