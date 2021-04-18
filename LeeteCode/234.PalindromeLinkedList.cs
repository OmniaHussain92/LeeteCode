using System;
using System.Collections.Generic;
using System.Text;

namespace LeeteCode.Link
{
    //   Definition for singly-linked list.
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

    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            if (slow.next == null)
            {
                return slow.val == head.val;
            }

            ListNode reversedHead = Resverse(fast == null ? slow : slow.next);

            while (head != null && reversedHead != null)
            {

                if (head.val != reversedHead.val)
                    return false;

                head = head.next;
                reversedHead = reversedHead.next;
            }

            return true;

        }

        public ListNode Resverse(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                ListNode next = curr.next;

                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;

        }

    }
}
