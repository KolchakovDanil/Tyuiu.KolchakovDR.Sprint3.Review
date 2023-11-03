using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint3.TaskReview.V15.Lib;

namespace Tyuiu.KolchakovDR.Sprint3.TaskReview.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = stop - start + 1;
            double[] wait = new double[len];
            wait[0] = 3.63;
            wait[1] = -11.70;
            wait[2] = -14.02;
            wait[3] = -5.24;
            wait[4] = 1.32;
            wait[5] = 0.00;
            wait[6] = -1.32;
            wait[7] = 5.24;
            wait[8] = 14.02;
            wait[9] = 11.70;
            wait[10] = -3.63;
            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
