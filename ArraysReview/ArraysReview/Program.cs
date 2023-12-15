using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace ArraysReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SwapTwonumbers.SwapNumbers();

            //Name validation
            //string str = "Hai";
            //string pattern = @"^[A-Z]{1}[a-z]*$";
            //Regex re = new Regex(pattern);

            //if (re.IsMatch(str))
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Not Valid");
            //}
            //Phone Number Validdation
            //string input = "919876543210";
            //string pattern1 = @"^+91[0-9]{10}$";
            //Regex reg = new Regex(pattern1);
            //if (reg.IsMatch(input))
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("Not valid");
            //}

            //ArrayDeletion.Array();

            List<ContactBook> book = new List<ContactBook>();
            //{
            //     new ContactBook { firstName = "microsoft", lastName = "C#", address = "asf12", city = "guntur", state = "ap", zipcode = 522253 },
            //     new ContactBook {firstName = "java", lastName ="James gosling", address= "bell labs", city= "usa", state="amd",zipcode = 522259},
            //     new ContactBook {firstName = "c", lastName ="gosling", address= "bell", city= "us", state="afr",zipcode = 560049},
            //     new ContactBook {firstName = "python", lastName ="gudio van", address= "russon89", city= "china", state="huwang",zipcode = 560349}
            //};
            int n = 0;
            while(n != 4)
            {
                Console.WriteLine("Enter Number to Do Something\n 0 : Add data\n 1 : Display\n 2 : Edit Name\n 3 : Remove\n 4 : Exit ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        book.Add(ContactBook.createContact());
                        break;
                    case 1:
                        foreach (ContactBook person in book)
                        {
                            Console.WriteLine(person);
                        }
                        break;
                    case 2:

                        Console.WriteLine("Enter Name to Edit : ");
                        string name = Console.ReadLine();
                        ContactBook findPerson = book.Find(x => x.firstName == name);
                        Console.WriteLine("Enter New Name : ");
                        string newName = Console.ReadLine();
                        findPerson.firstName = newName;
                        break;
                    case 3:

                        //foreach (ContactBook person in book)
                        //{
                        //    Console.WriteLine(person);
                        //}
                        Console.WriteLine("Enter Name to delete");
                        string findPerso = Console.ReadLine();
                        ContactBook findPerson1 = book.Find(x => x.firstName == findPerso);
                        book.Remove(findPerson1);

                        //foreach (ContactBook person in book)
                        //{
                        //    Console.WriteLine(person);
                        //}
                        break;
                    case 4:
                        Console.WriteLine("Exit.");
                        break;
                    default:
                        break;
                }
            
            }
        }

    }
}  
       
            
    

