using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DateAndTimeReview
{
    public class FileExist
    {
        public static void file()
        {
            string path = @"D:\temp\demo.doc";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Does Not Exists");
            }
            if()
        }

    }
}
