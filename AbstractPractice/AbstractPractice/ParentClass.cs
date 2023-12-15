using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
    public abstract class ParentClass
    {
        private string name;
        public void setname(string Name) 
        {
            this.name = Name;
        }
        public string Getname()
        {
            return name;
        }
       
        public int age;
        public abstract void showname();
        public void showAge() {
            Console.WriteLine(age);
        }
        
    }
}
