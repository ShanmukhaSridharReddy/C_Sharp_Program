using System;

namespace JavaPrograms1
{
    public class Seconds
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter seconds: ");
            double seconds = Convert.ToInt32(Console.ReadLine());
            double minutes = seconds / 60;
            Console.WriteLine(minutes);
        }
    }
}
