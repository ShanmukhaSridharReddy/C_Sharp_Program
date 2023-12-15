using System;

namespace DateTimeConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Getting current DateandTime
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Current DateTime"+dateTime);

            //Getting Universal time
            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine("Unoversal Time: "+utcNow);

            //Create Date and Time
            DateTime customDate = new DateTime(2002,06,01,11,45,00);
            Console.WriteLine("CustomizeDate"+customDate);

            //Giving DateTime Formate
            string formattedDate = utcNow.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("Date Formate"+formattedDate);

            //Parsing DateTime 
            string datestr = "2002-11-29";
            DateTime parsedTime = DateTime.ParseExact(datestr,"yyyy-MM-dd", null);
            Console.WriteLine(parsedTime);

            //Adding or Substracting of Time
            DateTime futureDate = DateTime.Now.AddDays(1);
            Console.WriteLine("FutureDate"+futureDate);
            DateTime PasteDate = DateTime.Now.AddHours(-48);
            Console.WriteLine("pasteDate"+PasteDate);

            //Comparising Dates 
            bool isForward = futureDate > DateTime.Now;
            Console.WriteLine( "futureDate:"+isForward );
            bool isbackward = PasteDate < DateTime.Now;
            Console.WriteLine( "PasteDate:"+isbackward );

            //TimeSpan
            TimeSpan Difference = futureDate - DateTime.Now;
            Console.WriteLine( "TimeSpan"+Difference );

            //Getting Components
            int Year = DateTime.Now.Year;
            int Month = DateTime.Now.Month;
            int Day = DateTime.Now.Day;
            Console.WriteLine("{0}/{1}/{2}",Day, Month, Year);

            //Getting DayofWeek
            DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;
            Console.WriteLine( "Day of the week : "+dayOfWeek );

            //Converting Date and Time into String
            string dateString = DateTime.Now.ToString();
            Console.WriteLine("String to date"+ dateString );

            //LeapYear
            bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Year + " is LeapYear : " + isLeapYear);

        }
    }
}
