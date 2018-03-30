using System.Collections.Generic;

namespace leetcode
{
    /// <summary>
    /// You are given two linked lists representing two non-negative numbers.
    /// The digits are stored in reverse order and each of their nodes contain a single digit.
    /// Add the two numbers and return it as a linked list.
    /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    /// Output: 7 -> 0 -> 8
    /// </summary>
    public class AddTwoNumbers
    {
        /// <summary>
        /// Two linked lists representing numbers with digits in reverse orders
        /// </summary>
        /// <param name="l1">number 1</param>
        /// <param name="l2">number 2</param>
        /// <returns>sum</returns>
        public ListNode Execute(ListNode l1, ListNode l2)
        {
            ListNode first = null;
            ListNode current = null;
            int overflow = 0;
            while(l1 != null || l2 != null)
            {
                var i = 0; // doesn't matter 'cause some value will rewrite it

                i += ExtractValue(l1);
                i += ExtractValue(l2);

                i += overflow;

                var node = new ListNode(i % 10);
                overflow = i >= 10 ? 1 : 0;

                if (first == null)
                {
                    first = node;
                }

                if (current != null)
                {
                    current.next = node;
                }

                current = node;

                MoveNext(ref l1);
                MoveNext(ref l2);
            }

            if (overflow != 0) {
                current.next = new ListNode(overflow);
            }

            return first;
        }

        /// <summary>
        /// Tries to extract value from node
        /// </summary>
        private int ExtractValue(ListNode l) {
            return null == l ? 0 : l.val;
        }

        /// <summary>
        /// Moves no next node (if exists)
        /// </summary>
        private void MoveNext(ref ListNode l) {
            if (l != null)
            {
                l = l.next;
            }
        }
    }

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    public class ListNodeDumper
    {
        public string Dump(ListNode l)
        {
            var res = new List<string>();
            while(l != null)
            {
                res.Add(l.val.ToString());
                l = l.next;
            }
            return string.Join("->", res.ToArray());
        }
    }
}
