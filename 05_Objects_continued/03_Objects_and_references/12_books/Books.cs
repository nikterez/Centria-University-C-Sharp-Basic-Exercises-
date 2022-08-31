using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_012_books
{
    public class Books
    {
        public string bookName;
        public int bookPublicationYear;

        public Books(string name, int publicationYear)
        {
            this.bookName = name;
            this.bookPublicationYear = publicationYear;
        }
        public bool Compare(Books book)
        {
            if (this.bookName == book.bookName && this.bookPublicationYear == book.bookPublicationYear)
            {
                return true;
            }

            return false;
        }
        public bool CheckDoubleEntry(List<Books> list)
        {
            foreach (var book in list)
            {
                //if (this.bookName == i.bookName && this.bookPublicationYear == i.bookPublicationYear)
                if (this.Compare(book))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Title: " + this.bookName + ", Year: " + this.bookPublicationYear;
        }
    }
}