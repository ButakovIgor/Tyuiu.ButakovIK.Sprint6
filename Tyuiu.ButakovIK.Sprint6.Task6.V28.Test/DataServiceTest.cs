using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ButakovIK.Sprint6.Task6.V28.Lib;
using System.IO;

namespace Tyuiu.ButakovIK.Sprint6.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask6V28.txt";

            string testOutput = "wFrlYaZtHI l eAezSXF eqSGAiC wUdVEuNB";
            string output = ds.CollectTextFromFile(path);
            Assert.AreEqual(testOutput, output);

        }
    }
}
