using System;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Child ch = new Child();
            ch.draw(4);
            MethodOverriding mn = new Child();
            mn.draw(4);

            MethodOverriding m = new MethodOverriding();
            m.draw(4);
        }
    }
}
