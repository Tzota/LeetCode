
namespace leetcode
{

    /// <summary>
    /// 21. Merge Two Sorted Lists
    /// Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
    /// Example:
    /// Input: 1->2->4, 1->3->4
    /// Output: 1->1->2->3->4->4
    /// </summary>
    public class MergeTwoSortedLists
    {
        private ListNode Cmp(ref ListNode x, ref ListNode y)
        {
            ListNode ans;
            if (x.val <= y.val)
            {
                ans = x;
                x = x.next;
            }
            else
            {
                ans = y;
                y = y.next;
            }
            ans.next = null;
            return ans;
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            var head = Cmp(ref l1, ref l2);
            var cursor = head;
            while (l1 != null && l2 != null)
            {
                var min = Cmp(ref l1, ref l2);
                cursor.next = min;
                cursor = min;
            }
            if (l1 != null) cursor.next = l1;
            if (l2 != null) cursor.next = l2;
            return head;
        }
    }
}
