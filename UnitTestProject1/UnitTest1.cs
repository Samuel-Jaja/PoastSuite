using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoastSuite;
using System.IO;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE 
            Program1 p1 = new Program1();
            double [,] S1 = new double[,]    //Expected Result
            {
                  {12},
                  {-6}
            };

            double[,] H1 = new double[,]
            {
                  {-1,0},
                  {0,-1}
            };

            double[,] g1 = new double[,]
            {
                  {-12},
                  {6}
            };

            //ACT 
            double[,] S11 = new double[,] { };    //Actual Result☺
            S11 = Program1.MatrixMultiplication(g1,H1);

            //ASSERT
            Assert.AreEqual(S1, S11);
        }
    }
}
