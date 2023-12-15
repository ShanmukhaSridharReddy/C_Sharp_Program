using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;

namespace CrudOperations
{
    public class Program
    {
        static void Main(string[] args)
        {

            SqlConnection sqlConnection;
            string connectionString = @"Data Source = PITTUBROTHERS\SQLEXPRESS01;Initial Catalog = StudentDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection Established SuccessFully");
                int choice = 0;
                while (choice != 5)
                {
                    Console.WriteLine("Select from the options below\n1.Creation\n2.Retrive\n3.Update\n4.Delete\n5.Exit");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            //Create => c
                            Console.WriteLine("Enter Name");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter Branch");
                            string Branch = Console.ReadLine();
                            string insertQuery = "INSERT INTO STUDENT(Name,Branch)values('" + Name + "','" + Branch + "')";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.ExecuteNonQuery();
                            Console.WriteLine("Data is inserted Successfully");
                            break;
                        case 2:
                            //Retrieve => R
                            string displayQuery = "SELECT * FROM STUDENT";
                            SqlCommand displayCommand = new SqlCommand(displayQuery, sqlConnection);
                            SqlDataReader dataReader = displayCommand.ExecuteReader();
                            while (dataReader.Read())
                            {
                                Console.WriteLine("id : " + dataReader.GetValue(0));
                                Console.WriteLine("Name : " + dataReader.GetValue(1));
                                Console.WriteLine("Branch : " + dataReader.GetValue(2));
                            }
                            dataReader.Close();
                            break;
                        case 3:
                            //UPDATE => U
                            int u_id;
                            string name;
                            Console.WriteLine("Enter user id which you want to update");
                            u_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the name you want to update");
                            name = Convert.ToString(Console.ReadLine());
                            string updateQuery = "update Student SET Name = '" + name + "' Where id =" + u_id + "";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                            updateCommand.ExecuteNonQuery();
                            Console.WriteLine("Data Updated Successfully");
                            break;
                        case 4:
                            //Delete => D

                            Console.WriteLine("Enter id number you want to delete");
                            int del_id = int.Parse(Console.ReadLine());
                            string deleteQuery = "DELETE FROM Student WHERE id = " + del_id;
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                            deleteCommand.ExecuteNonQuery();
                            Console.WriteLine("Deleted Successfully");
                            break;
                        case 5:
                            Console.WriteLine("Program is Completed");
                            break;

                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }

                }
                
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
    }
}
