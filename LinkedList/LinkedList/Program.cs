using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList List = new LinkedList();
            List.Insert(55);
            List.Insert(40);
            List.Insert(77);
            List.Insert(22);

            List.PrintOutput();
        }
    }
}
