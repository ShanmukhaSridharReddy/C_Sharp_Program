using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LinqReview
{
    class Employee
    {

        public string Name { get; set; }
        public string HireDate { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployee()
        {
            List<Employee> employee = new List<Employee>()
                {
                    new Employee()  { Name= "Harish" , HireDate = "05-07-2002" , Salary= 70000 },
                    new Employee() { Name = "sridhar" , HireDate = "06-08-2005" , Salary = 80000},
                    new Employee() { Name = "Amar" , HireDate= "02-04-2008", Salary = 40000},
                    new Employee() { Name = "Aman" , HireDate= "08-08-2020", Salary = 60000},
                    new Employee() { Name = "siva" , HireDate= "15-11-2017", Salary = 80000},
                    new Employee() { Name = "tarun" , HireDate= "26-12-2021", Salary = 70000},
                    new Employee() { Name = "suresh" , HireDate= "17-03-2022", Salary = 90000}

                };
            return employee;

        }
        public static double GetExperience(DateTime nowDate, string date)
        {
            DateTime hire = DateTime.ParseExact(date, "dd-MM-yyyy", null);
            double experience = (nowDate - hire).TotalDays / 365;
            return experience;
        }

        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            List<Employee> totalEmployee = Employee.GetEmployee();
            List<Employee> experienceYears = totalEmployee.FindAll(a => GetExperience(currentDate, a.HireDate)>5);
            List<Employee> highSalary = experienceYears.FindAll(e => e.Salary > 60000);
            foreach (var i in highSalary)
                Console.WriteLine(i.Name);

        }
    }
}

