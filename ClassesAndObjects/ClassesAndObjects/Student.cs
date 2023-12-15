using System;

namespace ClassesAndObjects
{
     class Student
    {
        public int rollno;
        public string name;
        public int age;
        public int standard;
        public void setstudent(int rollno, string name,int age,int standard)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }
        public void getstudent()
        {
            Console.WriteLine("Enter Roll no: {0} ",this.rollno);
            Console.WriteLine("Enter Name : {0} ", this.name);
            Console.WriteLine("Enter age : {0}", this.age);
            Console.WriteLine("Enter class: {0}", this.standard);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Roll no: ");
            //int rollno = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Age : ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Class : ");
            //int standard = int.Parse(Console.ReadLine());

            //Student student = new Student();
            //student.setstudent(rollno, name, age, standard);
            //student.getstudent();

            Student s = new Student();
            s.setstudent(5,"name",6,4);
            s.getstudent();
        }
    }
}
