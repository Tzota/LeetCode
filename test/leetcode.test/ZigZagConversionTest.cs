using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    // [TestClass]
    public class ZigZagConversionTest
    {
        ///P   A   H   N
        ///A P L S I I G
        ///Y   I   R
        // [TestMethod]
        public void ZigZagConversion_Sample1_OK()
        {
            var result = (new ZigZagConversion()).Convert("PAYPALISHIRING", 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", result);
        }

        /// 1   7    D
        /// 2 5 8 B E
        /// 3   9    F
        /// 4 6 A C
        // [TestMethod]
        public void ZigZagConversion_Sample2_OK()
        {
            var result = (new ZigZagConversion()).Convert("123456789ABCDEF", 4);
            Assert.AreEqual("17D258BE39F46AC", result);
        }
    }
}