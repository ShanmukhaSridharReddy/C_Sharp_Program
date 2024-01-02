using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EmployeePayRollCoreMVCApp.Models
{
    public class EmployeeDataAccessLayer
    {
        string connectionString = "Data Source=PITTUBROTHERS\\SQLEXPRESS01;Initial Catalog=MVCDB;Integrated Security=True";
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(" GetAllEmployee_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Employee employee = new Employee();

                    employee.EmployeeID = Convert.ToInt32(rd["EmployeeID"]);
                    employee.Name = rd["Name"].ToString();
                    employee.ProfileImage = rd["ProfileImage"].ToString();
                    employee.Gender = rd["Gender"].ToString();
                    employee.Department = rd["Department"].ToString();
                    employee.salary = (int)Convert.ToInt64(rd["salary"]);
                    employee.StartDate= DateTime.Parse((string)rd["StartDate"]);
                    employee.Notes = rd["Notes"].ToString();

                    list.Add(employee);
                }
                con.Close();
            }
            return list;
        }

        public void AddEmployee(Employee employee)
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddEmployee_sp", con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name",employee.Name);
                cmd.Parameters.AddWithValue("@ProfileImage", employee.ProfileImage);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@Department", employee.Department);
                cmd.Parameters.AddWithValue("@salary", employee.salary);
                cmd.Parameters.AddWithValue("@StartDate", employee.StartDate);
                cmd.Parameters.AddWithValue("@Notes", employee.Notes);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close() ;
            }
        }
        public void UpdateEmployee(Employee employee)
        {
            using(SqlConnection con=new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateEmployee_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@ProfileImage", employee.ProfileImage);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@Department", employee.Department);
                cmd.Parameters.AddWithValue("@salary", employee.salary);
                cmd.Parameters.AddWithValue("@StartDate", employee.StartDate);
                cmd.Parameters.AddWithValue("@Notes", employee.Notes);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteEmployee(Employee employee)
        {
            using( SqlConnection con=new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteEmployee_sp", con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeID",employee.EmployeeID);
                con.Open() ;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}
