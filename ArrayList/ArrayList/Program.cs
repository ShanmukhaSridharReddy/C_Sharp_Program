using System;
using System.Collections;

namespace ArrayListProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Welcome");
            arrayList.Add(100);
            arrayList.Add(15.2f);
            arrayList.Add("hello World");
            Console.WriteLine("ArrayList count : "+arrayList.Count);
            Console.WriteLine("ArrayList Capacity : "+arrayList.Capacity);
            Console.WriteLine("----------------ArrayList Elements Are-- USING FOR LOOP--------------");
            for( int i=0; i<arrayList.Count; i++ )
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine();

            ArrayList arrayList2 = new ArrayList() { 10,20,"hi"};
            arrayList.AddRange(arrayList2);
            Console.WriteLine("-------After Adding to the array--Using FOREACH LOOP---------");
            foreach( var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            string str = (string)arrayList[0];
            float f = (float)arrayList[2];
            Console.WriteLine("Element at 0 :"+str);
            Console.WriteLine("Element at 2 :"+f);
            Console.WriteLine();

            arrayList.Remove(15.2f);
            arrayList.RemoveAt(0);
            arrayList.RemoveRange(3, 2);
            Console.WriteLine("After Removing ArrayList Elements Are : ");
            foreach( var arr in arrayList)
            {
                Console.WriteLine(arr);
            }
            Console.WriteLine("Item Exists : "+arrayList.Contains(100));
            Console.WriteLine();
            Console.WriteLine("After Reversing Elements Are");
            arrayList.Reverse();
            foreach (var arr in arrayList)
            {
                Console.WriteLine(arr);
            }



        }
    }
}
