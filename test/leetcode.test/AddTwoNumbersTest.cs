using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class AddTwoNumbersTest
    {
        /// Input: (3 -> 2 -> 1) + (3 -> 2 -> 1)
        /// Output: 6 -> 4 -> 2
        [TestMethod]
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
            Assert.AreEqual(6, answer.val);
            Assert.AreEqual(4, answer.next.val);
            Assert.AreEqual(2, answer.next.next.val);
        }

        /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        /// Output: 7 -> 0 -> 8
        [TestMethod]
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
            Assert.AreEqual(7, answer.val);
            Assert.AreEqual(0, answer.next.val);
            Assert.AreEqual(8, answer.next.next.val);
        }

        /// Input: (3 -> 2) + (3 -> 2 -> 1)
        /// Output: 6 -> 4 -> 1
        [TestMethod]
        public void AddTwoNumbers_DifferentLengthNoOverflow_OK()
        {
            var x = new ListNode(3) {
                next = new ListNode(2)
            };

            var y = new ListNode(3) {
                next = new ListNode(2) {
                    next = new ListNode(1)
                }
            };

            var answer = (new AddTwoNumbers()).Execute(x, y);
            Assert.AreEqual(6, answer.val);
            Assert.AreEqual(4, answer.next.val);
            Assert.AreEqual(1, answer.next.next.val);
        }

        // Input: (2 -> 4 -> 3) + (5 -> 6)
        /// Output: 7 -> 0 -> 4
        [TestMethod]
        public void AddTwoNumbers_DifferenthWithOverflow_OK()
        {
            var x = new ListNode(2) {
                next = new ListNode(4) {
                    next = new ListNode(3)
                }
            };

            var y = new ListNode(5) {
                next = new ListNode(6)
            };

            var answer = (new AddTwoNumbers()).Execute(x, y);
            Assert.AreEqual(7, answer.val);
            Assert.AreEqual(0, answer.next.val);
            Assert.AreEqual(4, answer.next.next.val);
        }

        /// Input: (5) + (5)
        /// Output: 10
        [TestMethod]
        public void AddTwoNumbers_SameLengthWithOverflow2_OK()
        {
            var x = new ListNode(5);

            var y = new ListNode(5);

            var answer = (new AddTwoNumbers()).Execute(x, y);
            Assert.AreEqual(0, answer.val);
            Assert.AreEqual(1, answer.next.val);
        }
    }
}