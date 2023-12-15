using System;

namespace SinglyLinkedList
{
    public class Program
    {
        class Node 
        {
            public int head;
            public Node next;
            public Node( int data)
            {
                head = data;
                next = null;
            }
        }
        class LinkedList
        {
            Node head =null;
            public void Insert(int data)
            {
                Node node = new Node(data);
                node.head = data;
                node.next = null;
               
                if ( head == null )
                {
                    head = node;
                }
                else
                {
                    Node n = head;
                    while( n.next != null )
                    {
                       n= n.next;
                    }
                    n.next = node;
                }
            }
            public void PrintTheOutput()
            {
                Node n = head; 
                while(n.next != null)
                {
                    Console.WriteLine(n.head);
                    n = n.next;
                }
                Console.WriteLine(n.head);
            }
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(6);
            list.Insert(7);
            list.Insert(9);    
            list.Insert(8);
            list.PrintTheOutput();
        }
    }
}
