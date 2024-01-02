using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
    public abstract class ParentClass
    {
        private string name;
        private string eat;
        public string Getname()
        {
            return name;
            

        }
        public string GetEat()
        {
            return eat;
        }
        public void setname(string Name)
        {
            this.name = Name;
            
        }
        public void seteat(string eat)
        {
            this.eat = eat;
        }

        public int age;
        public abstract void showname();
        public void showAge() {
            Console.WriteLine(age);
        }
        
    }
}
