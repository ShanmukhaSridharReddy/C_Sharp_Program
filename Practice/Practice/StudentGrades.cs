using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class StudentGrades
    {
        public static void Grades()
        {

            Console.WriteLine("Enter Student Marks");
            int s1 = int.Parse(Console.ReadLine());
            if( s1 >= 0 && s1 <= 59)
            {
                Console.WriteLine("Grade : F");
            }
            if (s1 >= 60 && s1 <= 69)
            {
                Console.WriteLine("Grade : D");
            }
            if (s1 >= 70 && s1 <= 79)
            {
                Console.WriteLine("Grade : C");
            }
            if (s1 >= 80 && s1 <= 89)
            {
                Console.WriteLine("Grade : B");
            }
            if (s1 >= 90 && s1 <= 100)
            {
                Console.WriteLine("Grade : A");
            }
            else
            {
                Console.WriteLine("Enter numbers between");
            }
           

        }
    }
}
