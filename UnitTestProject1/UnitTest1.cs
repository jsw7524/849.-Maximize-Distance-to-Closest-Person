using System;
using _849.Maximize_Distance_to_Closest_Person;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();
            int result = sln.MaxDistToClosest(new int[] { 1, 0, 0, 0, 1, 0, 1 });
            Assert.AreEqual(result, 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Solution sln = new Solution();
            int result = sln.MaxDistToClosest(new int[] { 1, 0, 0, 0 });
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Solution sln = new Solution();
            int result = sln.MaxDistToClosest(new int[] { 1, 0, 0, 1, 0, 1, 0, 1 });
            Assert.AreEqual(result, 1);
        }
    }
}
