using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulation.Problem01
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

    public class Insertion
    {
        public ListNode RemoveElements(ListNode head, int val) {
            if (head is null)
            {
                return null;
            }
        
            ListNode newHead = head;
            ListNode prevNode = newHead;
            ListNode node;
        
            while(prevNode is object)
            {
                Console.WriteLine(prevNode.val);
                if (prevNode.val == val)
                {
                    prevNode = prevNode.next;
                }

                if (prevNode is null)
                {
                    Console.WriteLine("null!");
                }
            }
        
            newHead = prevNode;
        
            if (prevNode.next is object)
            {
                node = prevNode.next;
                while(node is object)
                {
                    if (node.val != val)
                    {
                        prevNode = node;
                        node = node.next;
                    }
                    else
                    {
                        prevNode = node.next;
                        node = node.next;
                    }
                }
            }
        
            return newHead;
        }
    }
}
