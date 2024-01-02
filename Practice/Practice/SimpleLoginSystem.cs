using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class SimpleLoginSystem
    {
        public static void Login()
        {
            string DBUserName = "abc123";
            string DBPassword = "abc@123";

            int loginAttempts = 3; 
            while ( loginAttempts > 0 )
            {
                Console.WriteLine("Enter username: ");
                string userName = Console.ReadLine() ;
                Console.WriteLine("Enter Password: ");
                string password = Console.ReadLine() ;
                if( userName == DBUserName && password == DBPassword)
                {
                    Console.WriteLine(" Login Successful ");
                    break;
                }
                else if ( userName != DBUserName)
                {
                    Console.WriteLine("Incorrect username ");
                }
                else if( password != DBPassword )
                {
                    Console.WriteLine("Incorrect Password ");
                }
                loginAttempts--;
                if( loginAttempts > 0 ) 
                {
                    Console.WriteLine($"You Have{loginAttempts} attempts Remaining");
                }
                else 
                { 
                    Console.WriteLine("Account locked");
                }
            }
        }
    }
}
