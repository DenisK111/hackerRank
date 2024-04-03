using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Easy
{
    internal class printLinkedListProblem
    {
        // https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list/

       public class SinglyLinkedListNode {
         public int data;
         public SinglyLinkedListNode next = null!;
     }

        static void printLinkedList(SinglyLinkedListNode head)
        {
            while(head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }

        }
    }
}
