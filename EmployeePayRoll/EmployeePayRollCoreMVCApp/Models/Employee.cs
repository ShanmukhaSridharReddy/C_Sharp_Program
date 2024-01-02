using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeePayRollCoreMVCApp.Models
{
    public class Employee
    {
        public int EmployeeID {  get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ProfileImage { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        public string Department {  get; set; }
        [Required]
        public int salary { get; set; }
        [Required]

        public DateTime StartDate { get; set; }
        public string Notes { get; set; }


    }
}
