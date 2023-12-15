using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ArraysReview
{
    public class ContactBook
    {

        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public int mobileNumber { get; set; }

        public static ContactBook createContact()
        {
            ContactBook person = new ContactBook();
            Console.WriteLine("Write Firstname : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Write Lastname : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address : ");
            string address = Console.ReadLine();
            Console.WriteLine("City : ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state : ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zipcode : ");
            int zipcode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mobile Numebr : ");
            int mobileNumber = int.Parse(Console.ReadLine());

            person.firstName = firstName;
            person.lastName = lastName;
            person.address = address;
            person.city = city;
            person.state = state;
            person.zipcode = zipcode;
            person.mobileNumber = mobileNumber;

            return person;
        }

        public override string ToString()
        {
            return "First Name : " + firstName + " Last Name : " + lastName + " Address : " + address + " City : " + city + " State : " + state + " Zipcode : " + zipcode + " Mobile Number : " + mobileNumber;
        }
    }
}
