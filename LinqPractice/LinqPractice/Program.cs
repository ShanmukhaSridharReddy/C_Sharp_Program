using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    public class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public string Department { get; set; }
            public static List<Employee> GetAllEmployees()
            {
                List<Employee> employee = new List<Employee>();
                {
                    new Employee { Id = 101, Name = "Pooja", Salary = 10000, Department = "IT" };
                    new Employee { Id = 102, Name = "Priyanka", Salary = 15000, Department = "Sales" };
                    new Employee { Id = 103, Name = "Manoj", Salary = 25000, Department = "Sales" };
                    new Employee { Id = 104, Name = "Santosh", Salary = 20000, Department = "IT" };
                    new Employee { Id = 105, Name = "Vishal", Salary = 30000, Department = "IT" };
                    new Employee { Id = 106, Name = "Sandhya", Salary = 25000, Department = "IT" };
                    new Employee { Id = 107, Name = "Mahesh", Salary = 35000, Department = "IT" };
                    new Employee { Id = 108, Name = "Manoj", Salary = 11000, Department = "Sales" };
                    new Employee { Id = 109, Name = "Pradeep", Salary = 20000, Department = "Sales" };
                    new Employee { Id = 110, Name = "Saurav", Salary = 25000, Department = "Sales" };

                };
                return employee;
            }
        }
        public static void Main(string[] args)
        {
            var method = Employee.GetAllEmployees().ToList();

            foreach (var employee in method)
            {
                Console.WriteLine($"Id : {employee.Id} Name : {employee.Name} Salary : {employee.Salary} Department : {employee.Department}");
            }
            var Query = (from emp in Employee.GetAllEmployees() select emp).ToList();
            foreach (var i in Query)
            {
                Console.WriteLine($"Id : { i.Id} Name : {i.Name}");
            }
        }
    }
}
