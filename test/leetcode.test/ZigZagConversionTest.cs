using leetcode;
using NUnit.Framework;

namespace leetcode_test
{
    // [TestFixture]
    public class ZigZagConversionTest
    {
        ///P   A   H   N
        ///A P L S I I G
        ///Y   I   R
        // [Test]
        public void ZigZagConversion_Sample1_OK()
        {
            var result = (new ZigZagConversion()).Convert("PAYPALISHIRING", 3);
            Assert.That(result, Is.EqualTo("PAHNAPLSIIGYIR"));
        }

        /// 1   7    D
        /// 2 5 8 B E
        /// 3   9    F
        /// 4 6 A C
        // [Test]
        public void ZigZagConversion_Sample2_OK()
        {
            var result = (new ZigZagConversion()).Convert("123456789ABCDEF", 4);
            Assert.That(result, Is.EqualTo("17D258BE39F46AC"));
        }
    }
}