using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummyNode = new ListNode(-1);
            ListNode tail = dummyNode;
            while (true)
            {
                if (l1 == null)
                {
                    tail.next = l2;
                    break;
                }
                if (l2 == null)
                {
                    tail.next = l1;
                    break;
                }

                if (l1.val <= l2.val)
                {
                    tail.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    tail.next = l2;
                    l2 = l2.next;
                }
                tail = tail.next;
            }
            return dummyNode.next;
        }
    }
}
