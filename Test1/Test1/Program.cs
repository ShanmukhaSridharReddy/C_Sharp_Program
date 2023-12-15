using System;

namespace Test1
{
    public class Program
    {
        public string GetName(string FirstName, string LastName)
        {
            return string.Concat(FirstName, LastName);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
