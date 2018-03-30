
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class MergeTwoSortedListsTest
    {
        private ListNodeDumper dumper = new ListNodeDumper();

        [TestMethod]
        public void MergeTwoSortedLists_OneIsNull_AnotherList()
        {
            var x = new ListNode(1) {
                next = new ListNode(2)
            };
            var actual = (new MergeTwoSortedLists()).MergeTwoLists(x, null);

            Assert.AreEqual("1->2", dumper.Dump(actual));
        }

        [TestMethod]
        public void MergeTwoSortedLists_OneNode_Result()
        {
            var x = new ListNode(1);
            var actual = (new MergeTwoSortedLists()).MergeTwoLists(x, null);

            Assert.AreEqual("1", dumper.Dump(actual));
        }

        [TestMethod]
        public void MergeTwoSortedLists_OneIsShorter_Result()
        {
            var x = new ListNode(1) {
                next = new ListNode(2)
            };
            var y = new ListNode(1);
            var actual = (new MergeTwoSortedLists()).MergeTwoLists(x, y);

            Assert.AreEqual("1->1->2", dumper.Dump(actual));
        }

        [TestMethod]
        public void MergeTwoSortedLists_SameLength_Result()
        {
            var x = new ListNode(1) {
                next = new ListNode(2)
            };
            var y = new ListNode(1) {
                next = new ListNode(2)
            };
            var actual = (new MergeTwoSortedLists()).MergeTwoLists(x, y);

            Assert.AreEqual("1->1->2->2", dumper.Dump(actual));
        }

        [TestMethod]
        public void MergeTwoSortedLists_OneAfterAnother_Result()
        {
            var x = new ListNode(1) {
                next = new ListNode(2)
            };
            var y = new ListNode(3) {
                next = new ListNode(4)
            };
            var actual = (new MergeTwoSortedLists()).MergeTwoLists(x, y);

            Assert.AreEqual("1->2->3->4", dumper.Dump(actual));
        }

        [TestMethod]
        public void MergeTwoSortedLists_SameNumber_Result()
        {
            var x = new ListNode(1) {
                next = new ListNode(1)
            };
            var y = new ListNode(1);
            var actual = (new MergeTwoSortedLists()).MergeTwoLists(x, y);

            Assert.AreEqual("1->1->1", dumper.Dump(actual));
        }

        [TestMethod]
        public void MergeTwoSortedLists_Positive_Result()
        {
            var x = new ListNode(1) {
                next = new ListNode(3) {
                    next = new ListNode(5)
                }
            };
            var y = new ListNode(2) {
                next = new ListNode(4) {
                    next = new ListNode(6)
                }
            };
            var actual = (new MergeTwoSortedLists()).MergeTwoLists(x, y);

            Assert.AreEqual("1->2->3->4->5->6", dumper.Dump(actual));
        }
    }
}
