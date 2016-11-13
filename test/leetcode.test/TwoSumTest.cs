using leetcode;
using NUnit.Framework;


namespace leetcode_test
{
    [TestFixture]
    public class TwoSumTest
    {
        [Test]
        public void TwoSum_Neighbours_OK() 
        {
            int[] answer = new TwoSum().Find(new int[] { 2, 7, 11, 15 }, 9);
            Assert.That(answer, Has.Exactly(1).EqualTo(0));
            Assert.That(answer, Has.Exactly(1).EqualTo(1));
        }

        [Test]
        public void TwoSum_Distant_OK() 
        {
            int[] answer = new TwoSum().Find(new int[] { 2, 11, 7, 15 }, 9);
            Assert.That(answer, Has.Exactly(1).EqualTo(0));
            Assert.That(answer, Has.Exactly(1).EqualTo(2));
        }

        [Test]
        public void TwoSum_NoExtraMembers_OK() 
        {
            int[] answer = new TwoSum().Find(new int[] { 2, 7}, 9);
            Assert.That(answer, Has.Exactly(1).EqualTo(0));
            Assert.That(answer, Has.Exactly(1).EqualTo(1));
        }
    }
}