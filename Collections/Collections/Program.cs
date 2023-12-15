using System;
using System.Collections;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(1000);

            al.Add(200);
            al.Add(300);
            al.Add(400);
            Console.WriteLine(al.Capacity);
            foreach(int i in al)
                Console.Write(i+" ");
            Console.WriteLine();

            al.Insert(3, 350);
            foreach(int i in al)
                Console.Write(i+" ");
            Console.WriteLine();

            al.Remove(200);
            foreach(int i in al)
                Console.Write(i+" ");
            Console.WriteLine();

        }
    }
}
