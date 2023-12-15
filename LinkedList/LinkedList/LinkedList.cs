using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        Node head;
        public void Insert(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head != null)
            {
                head = node;

            }
            else
            {
                Node no = head;
                while (no.next != null)
                {
                    no = no.next;
                }
               // no.next = node;

            }
        }

           public void PrintOutput()
        {
            Node node = head;
            while (node.next != null)
            {
                node = node.next;
                Console.WriteLine(node.data);
            }
            Console.WriteLine(node.data);
        }
        
    }
}
