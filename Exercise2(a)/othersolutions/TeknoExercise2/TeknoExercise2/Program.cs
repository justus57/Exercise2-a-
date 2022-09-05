using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise2_a_.LinkedListHelpers;

namespace TeknoExercise2
{
    class Program
    {   
        static void Main(string[] args)
        {
            node start = new node("A");
            start.next = new node("B");
            start.next.next = new node("B");
            start.next.next.next = new node("C");
            start.next.next.next.next = new node("C");
            start.next.next.next.next.next = new node("D");
            start.next.next.next.next.next.next = new node("D");

            Console.WriteLine("Linked list before removing "
                              + "duplicates :");
            printList(start);
            removeDuplicate(start);
            Console.WriteLine("\nLinked list after removing "
                              + "duplicates :");
            printList(start);
            Console.ReadLine();
        }

    }
    
}
