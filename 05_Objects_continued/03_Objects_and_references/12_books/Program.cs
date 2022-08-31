using System;
using System.Collections.Generic;

namespace Exercise_012_books
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Books> bookList = new List<Books>();
            int counter = 0;

            while (true)
            {
                Console.WriteLine("Name (empty will stop):");
                string title = Console.ReadLine();

                if (title == "")
                {
                    break;
                }

                System.Console.WriteLine("Publication year:");
                int year = Convert.ToInt32(System.Console.ReadLine());

                Books book = new Books(title, year);

                if (book.CheckDoubleEntry(bookList))
                {
                    System.Console.WriteLine("The book is already on the list. Let's not add the same book again.");
                    continue;

                }

                bookList.Add(book);
                counter++;
            }

            foreach (var book in bookList)
            {
                System.Console.WriteLine(book);
            }

            System.Console.WriteLine("Thank you! Books added: " + counter);
        }
    }
}
