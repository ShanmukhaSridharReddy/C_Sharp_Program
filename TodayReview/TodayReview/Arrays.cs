using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodayReview
{
    public class Arrays
    {
        public static void FileOperation()
        {
            string path = @"D:\temp\test.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }


            //string copypath = @"D:\temp\demo\test.pdf";
            File.Create(path);
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
        }
         public static void VoewlsAndConsonents ()
         {
            string str = Convert.ToString(Console.ReadLine());
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {

                if (str == "a" || str == "e" || str == "i" || str == "o" || str == "u")
                {

                    Console.WriteLine("Vowels are:" + i);
                }
                else
                {
                    Console.WriteLine("Consonents:" + i);
                }

            }
         }

    
     public static void LinqPositiveNumbers() {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, -7, -8, -9 };

            var s = from num in numbers where num > 0 & num < 9 select num;
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
      }
    }
   
        

}
