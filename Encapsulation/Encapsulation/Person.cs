using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Person
    {
        private string name;
        private int age;

        public void setName(string name)
        {
            this.name = name;
        }
        public void getName()
        { 
            Console.WriteLine("Your name is : "+this.name);
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void getAge()
        {
            Console.WriteLine("Your Age is : "+this.age);
        }
    }
}
