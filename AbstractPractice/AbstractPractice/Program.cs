using System;

namespace AbstractPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChldClass obj = new ChldClass();
            obj.showname();
            ChldClass ch = new ChldClass();
            ch.setname("child");
            obj.setname("dog");
         
            Console.WriteLine(ch.Getname());
            Console.WriteLine(obj.Getname());

        }
    }
}
