using leetcode;
using NUnit.Framework;

namespace leetcode_test
{
    [TestFixture]
    public class AddTwoNumbersTest
    {
        /// Input: (3 -> 2 -> 1) + (3 -> 2 -> 1)
        /// Output: 6 -> 4 -> 2
        [Test]
        public void AddTwoNumbers_SameLengthNoOverflow_OK()
        {
            var x = new ListNode(3) {
                next = new ListNode(2) {
                    next = new ListNode(1)
                }
            };

            var y = new ListNode(3) {
                next = new ListNode(2) {
                    next = new ListNode(1)
                }
            };

            var answer = (new AddTwoNumbers()).Execute(x, y);
            Assert.That(answer.val, Is.EqualTo(6));
            Assert.That(answer.next.val, Is.EqualTo(4));
            Assert.That(answer.next.next.val, Is.EqualTo(2));
        }

        /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        /// Output: 7 -> 0 -> 8
        [Test]
        public void AddTwoNumbers_SameLengthWithOverflow_OK()
        {
            var x = new ListNode(2) {
                next = new ListNode(4) {
                    next = new ListNode(3)
                }
            };

            var y = new ListNode(5) {
                next = new ListNode(6) {
                    next = new ListNode(4)
                }
            };

            var answer = (new AddTwoNumbers()).Execute(x, y);
            Assert.That(answer.val, Is.EqualTo(7));
            Assert.That(answer.next.val, Is.EqualTo(0));
            Assert.That(answer.next.next.val, Is.EqualTo(8));
        }
    }
}