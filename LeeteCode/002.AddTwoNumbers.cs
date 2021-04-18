using System;
using System.Collections.Generic;
using System.Text;

namespace LeeteCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class _2AddTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var strNum1 = l1.val.ToString();
            var strNum2 = l2.val.ToString();

            while (l1.next != null)
            {
                l1 = l1.next;
                strNum1 = l1.val.ToString() + strNum1;
            }

            while (l2.next != null)
            {
                l2 = l2.next;
                strNum2 = l2.val.ToString() + strNum2;
            }

            ListNode sumNode = new ListNode();
            ListNode res = sumNode;
            var sum = (int.Parse(strNum1) + int.Parse(strNum2)).ToString();
            sumNode.val = int.Parse(sum[sum.Length - 1].ToString());
            for (int i = sum.Length - 2; i >= 0; i--)
            {
                sumNode.next = new ListNode();
                sumNode = sumNode.next;
                sumNode.val = int.Parse(sum[i].ToString());
            }

            return res;
        }
        public static ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode p = l1; ListNode q = l2; ListNode curr = head;
            int carry = 0;

            while (p != null || q != null)
            {
                int pval = p != null ? p.val : 0;
                int qval = q != null ? q.val : 0;
                int sum = carry + pval + qval;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }

            return head.next;
        }
    }
}
