
using leetcode;
using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestCategory("ClimbingStairs")]
    [TestClass]
    public class ClimbingStairsTest
    {
        [TestMethod]
        public void ClimbingStairs_1_1()
        {
            Assert.AreEqual(1, new ClimbingStairs().ClimbStairs(1));
        }

        [TestMethod]
        public void ClimbingStairs_2_2()
        {
            Assert.AreEqual(2, new ClimbingStairs().ClimbStairs(2));
        }

        [TestMethod]
        public void ClimbingStairs_3_3()
        {
            Assert.AreEqual(3, new ClimbingStairs().ClimbStairs(3));
        }

        [TestMethod]
        public void ClimbingStairs_4_5()
        {
            Assert.AreEqual(5, new ClimbingStairs().ClimbStairs(4));
        }

        [TestMethod]
        public void ClimbingStairs_44_1134903170()
        {
            var sw = Stopwatch.StartNew();
            Assert.AreEqual(1134903170, new ClimbingStairs().ClimbStairs(44));
            sw.Stop();
            TimeSpan time = sw.Elapsed;
            Assert.IsTrue(sw.ElapsedMilliseconds < 1000, "504 Timeout");
        }
    }
}

/*
1,1,1,1
1,1,2
1,2,1
2,1,1
2,2
 */
