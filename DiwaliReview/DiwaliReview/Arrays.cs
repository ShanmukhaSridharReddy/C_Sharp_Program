using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace DiwaliReview
{
    public class Arrays
    {
        public static void Array()
        {
            
            Console.WriteLine("Enter Size of an Array : ");
            int size= int .Parse(Console.ReadLine());
            int[] Array=new int[size];
           Console.WriteLine("Enter Elements into Array : ");
            for( int i=0; i<size; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine();
            foreach( int i in Array)
            {
                Console.WriteLine("After entering the Elements into Array : "+i);
            }
            Console.WriteLine() ;
            Console.WriteLine("Enter position where  you want to delete the Element: ") ;
            int pos= int.Parse(Console.ReadLine());
            if (pos < 0 || pos > size)
            {
                Console.WriteLine("Invlalid position : " + pos);
            }
            int[] newArray = new int[size-1];
                int index = 0;
                for(int i=0; i< size; i++)
                {
                    if(pos !=i)
                    {
                        newArray[index] = Array[i];
                    index++;
                    }                
                }
                Console.WriteLine() ;
                foreach( int i in newArray)
                {
                    Console.WriteLine(i);
                }
                

        }
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
        public static void VoewlsAndConsonents()
        {
            Console.WriteLine("Enter a String");
            string str = Convert.ToString(Console.ReadLine());
            str = str.ToLower();
            int vowelCount = 0;
            int count = 0;
            
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {

                    Console.WriteLine("Vowels are:" + str[i]);
                    vowelCount++;
                }
                else
                {
                    Console.WriteLine("Consonents:" + str[i]);
                    count++;
                }

            }
            Console.WriteLine("In A Given String Vowels Are : " +vowelCount+" in Count");
            Console.WriteLine("In A Given Stirng Consonents Are : " + count + " in count");
        }


        public static void LinqPositiveNumbers()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, -7, -8, -9 };

            var s = from num in numbers where num > 0 & num < 9 select num;
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
        }
    }



    

}

