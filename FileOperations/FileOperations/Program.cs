using System;
using System.IO;

namespace FileOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\temp\demo\demo.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.WriteLine();

            //using arrays
            Console.WriteLine("using Array");
            string[] a= File.ReadAllLines(path);
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine();

            //using variable
            Console.WriteLine("using Variable");
            string line = File.ReadAllText(path);
            Console.WriteLine(line);
            Console.WriteLine();

            //File Copy
            string path1 = @"D:\temp\demo\demo.txt";
            string cpy = @"D:\temp\demo\demo.pdf";
            File.Copy(path1, cpy);

            if (File.Exists(cpy))
                Console.WriteLine("File Exists");

            File.Delete(cpy);
            if (File.Exists(cpy))
                Console.WriteLine("File Exists");
            else Console.WriteLine("File Does not Exists");
            Console.WriteLine();

            //Using StreamRead
            Console.WriteLine("Using Streams");
            using (StreamReader sr = File.OpenText(path))
            {
                string str = "";
                while( (str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            Console.WriteLine();

            // streanmWrite
            using(StreamWriter wr = File.AppendText(path))
            {
                wr.WriteLine(" This is Written by compiler");
                wr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.WriteLine() ;
        }
    }
}
