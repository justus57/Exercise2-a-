
using System;
using System.Collections.Generic;

namespace Exercise2_a_
{
    public class LinkedListHelpers
    {
      public class node
        {
            public string val;
            public node next;
            public node(string val) { this.val = val; }
        }
     public  static void removeDuplicate(node head)
        {
            HashSet<string> hs = new HashSet<string>();

            node current = head;
            node prev = null;
            while (current != null)
            {
                string curval = current.val;
                if (hs.Contains(curval))
                {
                    prev.next = current.next;
                }
                else
                {
                    hs.Add(curval);
                    prev = current;
                }
                current = current.next;
            }
        }
        // Function to print nodes in a
        // given linked list
       public static void printList(node head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }

    }

}
