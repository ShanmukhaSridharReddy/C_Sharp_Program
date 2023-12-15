using System;

namespace StringConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Shanmukha Sridhar";
            string LastName = "Reddy";

            //Finding Length
            Console.WriteLine(FirstName.Length);
            Console.WriteLine(LastName.Length);

            //ConCatination
            Console.WriteLine(FirstName + " " + LastName);

            //Finding IndexValue
            Console.WriteLine(FirstName[6]);

            //Substring
            Console.WriteLine(FirstName.Substring(6));
            Console.WriteLine(LastName.Substring(1,4));

            //ToLowerCase & ToUpperCase
            Console.WriteLine(FirstName.ToUpper());
            Console.WriteLine(LastName.ToLower());

            //Split & Trim
            Console.WriteLine(FirstName.Split(" "));
            Console.WriteLine(FirstName.Trim());

            Console.WriteLine(FirstName.EndsWith("ar"));
            Console.WriteLine(LastName.StartsWith("re"));

            
        }
    }
}
