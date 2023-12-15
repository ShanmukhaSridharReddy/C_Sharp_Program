using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQListProblem
{
    public class Program
    {
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public string Department { get; set; }
            public static List<Employee> GetAllEmployees()
            {
                List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ID= 101,Name = "Pooja", Salary = 10000, Department = "IT"},
                new Employee{ID= 102,Name = "Priyanka", Salary = 15000, Department = "Sales"},
                new Employee{ID= 103,Name = "Manoj", Salary = 25000, Department = "Sales"},
                new Employee{ID= 104,Name = "Santosh", Salary = 20000, Department = "IT"},
                new Employee{ID= 105,Name = "Vishal", Salary = 30000, Department = "IT"},
                new Employee{ID= 106,Name = "Sandhya", Salary = 25000, Department = "IT"},
                new Employee{ID= 107,Name = "Mahesh", Salary = 35000, Department = "IT"},
                new Employee{ID= 108,Name = "Manoj", Salary = 11000, Department = "Sales"},
                new Employee{ID= 109,Name = "Pradeep", Salary = 20000, Department = "Sales"},
                new Employee{ID= 110,Name = "Saurav", Salary = 25000, Department = "Sales"}
            };
                return listEmployees;
            }
            static void Main(string[] args)
            {

                //var Method = Employee.GetAllEmployees().ToList();
                //foreach (var emp in Method)
                //{
                //    Console.WriteLine($"ID : {emp.ID} Name : {emp.Name} {emp.Salary}");
                //}
                //Console.WriteLine();
                //var Query = ( from emp in Employee.GetAllEmployees() select emp).ToList();
                //foreach ( var emp in Query)
                //{
                //    Console.WriteLine($"ID : {emp.ID} Name : {emp.Name} Department : {emp.Department}");
                //}

                //var method1 = Employee.GetAllEmployees().Where(w => w.Department == "IT");
                //foreach (var v in method1)
                //{
                //    Console.WriteLine($"ID : {v.ID} Name : {v.Name} Department : {v.Department}");
                //}
                //Console.WriteLine();
                //var Query1 = (from empl in Employee.GetAllEmployees() where empl.Department == "Sales" select empl);
                //foreach(var i in Query1)
                //{
                //    Console.WriteLine($"ID : {i.ID} Name : {i.Name} Department : {i.Department}");
                //}

                //var method2 = Employee.GetAllEmployees().Select( x => x.Name).Distinct().ToList();
                //var Query2 = (from a in Employee.GetAllEmployees() select a.Name).Distinct().ToList();
                //foreach ( var emp in  method2)
                //{
                //    Console.WriteLine(emp);
                //}
                //Console.WriteLine();
                //foreach( var emp in Query2)
                //{
                //    Console.WriteLine(emp);
                //}

            }
            
        }
    }
}
