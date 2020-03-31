using System;

namespace _1290_binary
{
    class Binary
    {
        /* Admittedly looked at @gleslie2008 solution and rewrote from memory */
        /* https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/discuss/474803/C-Recursive-O(n)-96-time-100-memory */

        public void run()
        {
            ListNode head = new ListNode(1);
            ListNode tail = new ListNode(1);
            ListNode second = new ListNode(0);
            head.next = second;
            second.next = tail;
            Console.WriteLine(GetDecimalValue(head));
        }

        public int GetDecimalValue(ListNode head)
        {
            int counter = 0, total = 0;
            recurseList(head, ref counter, ref total);
            return total;
        }

        public void recurseList(ListNode head, ref int counter, ref int total)
        {
            if (head.next != null)
            {
                recurseList(head.next, ref counter, ref total);
            }

            if (head.val == 1)
                total += (int)Math.Pow(2, counter);
            counter++;

        }
    }
}
