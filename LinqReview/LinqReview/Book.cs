using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LinqReview
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int PublishedYear { get; set; }
        public Book()
        {
           
        }
        public Book(string title, string author, double price, int year)
        {
            Title = title;
            Author = author;
            Price = price;
            PublishedYear = year;
        }
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;

        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            PublishedYear = year;
        }
        static void Main(string[] args)
        {
            Book book1 = new Book("C#","Microsoft",500.45, 2015);
            Console.WriteLine("Book Title : {0}\nBook Author : {1}\nBook Price : {2}\nBook Year : {3}",book1.Title, book1.Author, book1.Price, book1.PublishedYear);
            Console.WriteLine();
            Book book2 = new Book("Java", "James Gosling", 1500.45);
            Console.WriteLine("Book Title : {0}\nBook Author : {1}\nBook Price : {2}", book2.Title, book2.Author, book2.Price);
            Console.WriteLine();
            Book book3 = new Book("Ramayana", "Valmiki");
            Console.WriteLine("Book Title : {0}\nBook Author : {1}", book3.Title, book3.Author);
            Console.WriteLine();
            Book book4 = new Book("HTMl", "Hemanth", 2000);
            Console.WriteLine("Book Title : {0}\nBook Author : {1}\nBook Year : {2}", book4.Title, book4.Author, book4.PublishedYear);

        }

    }
}
