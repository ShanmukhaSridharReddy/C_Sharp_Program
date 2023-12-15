using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LinQ
{
    public class Program
    {
        public class Student
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Department { get; set; }

            public static List<Student> GetStudents()
            {
                List<Student> student = new List<Student>()
                {
                    new Student { RollNo = 101, Name = "Suresh", Age = 23,  Department = "CSE" },
                    new Student { RollNo = 102, Name = "Dileep", Age = 23,  Department ="ECE" },
                    new Student { RollNo = 103, Name = "Dileep", Age = 22,  Department = "CSE" },
                    new Student { RollNo = 104, Name = "Tarun",  Age = 22 , Department = "CSE"},
                    new Student { RollNo = 105, Name = "Balaji", Age = 23 , Department = "CSE"},
                    new Student { RollNo = 106, Name = "SivaTeja", Age = 23 ,Department = "CSE" },
                    new Student { RollNo = 107, Name = "Sagar" , Age = 25,  Department ="Mech"},
                    new Student { RollNo = 108, Name = "Sonu" ,  Age = 25,  Department ="Mech"},
                    new Student { RollNo = 109, Name = "BalaKrishna" , Age = 22, Department="civil" },
                    new Student { RollNo = 110, Name = "Sai",    Age= 25,   Department = "civil"},
                    new Student { RollNo = 111, Name = "Manohar" , Age= 22, Department ="CSE"},
                    new Student { RollNo = 112, Name = "Srikanth" , Age= 23,Department="CSE" },
                    new Student { RollNo = 113, Name = "Chari",  Age=23,    Department="ECE" },
                    new Student { RollNo = 114, Name = "jogendra",Age = 22, Department="ECE"},
                    new Student { RollNo = 115, Name = "Saida",  Age = 23 , Department ="ECE"},
                    new Student { RollNo = 116, Name = "Ganesh" , Age = 22, Department ="CSE" },
                    new Student { RollNo = 117, Name = "Husain", Age= 22,   Department="Mech" },
                    new Student { RollNo = 118, Name = "Ganesh", Age = 23,  Department="Mech"},
                    new Student { RollNo = 119, Name = "Basha" , Age =22,   Department = "ECE" },
                    new Student { RollNo = 120, Name = "koti",   Age= 21,   Department ="EEE"},
                    new Student { RollNo = 121, Name = "Naveen", Age = 24,  Department = "ECE"},
                    new Student { RollNo = 122, Name = "Riyaz",  Age = 24,  Department = "EEE"},
                    new Student { RollNo = 123, Name= "chandra" , Age = 24, Department ="EEE"},
                    new Student { RollNo = 124, Name = "Allabakshu", Age = 23,Department = "CSE"},
                    new Student { RollNo = 125, Name = "Kishore", Age = 24, Department="CSE"}


                };

                return student;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
                var st = Student.GetStudents().Where(w => w.Name == "Dileep").ToList(); 
            foreach ( var s in st )
            {
                Console.WriteLine($"RollNo: { s.RollNo} Name : {s.Name} Age : {s.Age} Department : {s.Department}");
            }
                        Console.WriteLine("Hello World!");
            var v = Student.GetStudents().Where( w => w.Age >23 & w.Age<25).ToList();
            foreach (var vs in v)
            {
                Console.WriteLine($"RollNo: {vs.RollNo} Name : {vs.Name} Age : {vs.Age} Department : {vs.Department}");
            }
            Console.WriteLine("Hello World!");
            var query = (from s in Student.GetStudents() where s.Department == "CSE" select s).ToList();
            foreach (var s in query)
            {
                Console.WriteLine($"RollNo: {s.RollNo} Name : {s.Name} Age : {s.Age} Department : {s.Department}");
            }
            Console.WriteLine("Hello World!");
            var query1 = (from z in Student.GetStudents() where z.Age == 22  select z).ToList();
            foreach (var tab in query1)
            {
                Console.WriteLine($"RollNo: {tab.RollNo} Name : {tab.Name} Age : {tab.Age} Department : {tab.Department}");
            }
            Console.WriteLine("Hello World!");
            var Result = Student.GetStudents();

            if (Result != null)
            {
                foreach (var item in Result)
                {
                    Console.WriteLine($"RollNo : {item.RollNo} Name : {item.Name} Age : {item.Age} ");
                }

            }

        }
    }
}
