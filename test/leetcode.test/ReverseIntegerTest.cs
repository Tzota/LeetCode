using leetcode;
using NUnit.Framework;

namespace leetcode_test
{
    [TestFixture]
    public class ReverseIntegerTest
    {
        [Test]
        public void ReverseIntegerTest_SmallInt_OK()
        {
            var answer = (new ReverseInteger()).Execute(1);
            Assert.That(answer, Is.EqualTo(1));
        }

        [Test]
        public void ReverseIntegerTest_SimpleInt_OK()
        {
            var answer = (new ReverseInteger()).Execute(123);
            Assert.That(answer, Is.EqualTo(321));
        }

        [Test]
        public void ReverseIntegerTest_NegativeIntOdd_OK()
        {
            var answer = (new ReverseInteger()).Execute(-123);
            Assert.That(answer, Is.EqualTo(-321));
        }

        [Test]
        public void ReverseIntegerTest_NegativeIntEven_OK()
        {
            var answer = (new ReverseInteger()).Execute(-1234);
            Assert.That(answer, Is.EqualTo(-4321));
        }

        [Test]
        public void ReverseIntegerTest_Overflow_Zero()
        {
            // 2147483647
            // 1111111113
            var answer = (new ReverseInteger()).Execute(1111111113);
            Assert.That(answer, Is.EqualTo(0));
        }

        [Test]
        public void ReverseIntegerTest_TrailingZero_OK()
        {
            var answer = (new ReverseInteger()).Execute(100);
            Assert.That(answer, Is.EqualTo(1));
        }

        [Test]
        public void ReverseIntegerTest_DoubleOverflow_Zero()
        {
            var answer = (new ReverseInteger()).Execute(1534236469);
            Assert.That(answer, Is.EqualTo(0));
        }


    }
}