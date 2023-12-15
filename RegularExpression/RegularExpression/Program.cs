using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Checking it contains Number or Not
            string input = "Hai Hello 123";
            string pattern = @"[0-9]";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }


            //PhoneNumber Validation
            string input2 = "9807543216";
            string pattern2 = @"^[0-9]{10}$";
            Regex regex2 = new Regex(pattern2);

            if (regex2.IsMatch(input2))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
            Console.WriteLine();

            //Email Validation
            Console.WriteLine("Email Validation");
            string input3 = "iAmtheboss123@gmail.com";
            string pattern3 = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex regex3 = new Regex(pattern3);
            if (regex3.IsMatch(input3))
            {
                Console.WriteLine("valid");

            }
            else
            {
                Console.WriteLine("Not valid");
            }
            Console.WriteLine   () ;

            //Taking input frim the user and validate
            Console.WriteLine("Taking input and validate");
            Console.WriteLine("Enter a String");
            string input4 = Convert.ToString(Console.ReadLine());
            string pattern4 = @"^[a-zA-Z]{1,}$";

            Regex regex4 = new Regex(pattern4);
            if (regex4.IsMatch(input4))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
            Console.WriteLine ();

           

        }
    }
}
