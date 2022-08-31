using System;
using System.Collections.Generic;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            while (true)
            {
                System.Console.WriteLine("Book title: ");
                string title = Console.ReadLine();

                if (title == "")
                {
                    break;
                }

                System.Console.WriteLine("Book pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("Year published");
                int year = Convert.ToInt32(Console.ReadLine());

                books.Add(new Book(title, pages, year));
            }

            System.Console.WriteLine("What information will be printed?");
            string input = Console.ReadLine();

            if (input.ToLower() == "everything")
            {
                foreach (Book i in books)
                {
                    System.Console.WriteLine(i);
                }
            }
            else if (input.ToLower() == "title")
            {
                foreach (Book i in books)
                {
                    System.Console.WriteLine(i.bookTitle);
                }

            }
        }
    }
}

