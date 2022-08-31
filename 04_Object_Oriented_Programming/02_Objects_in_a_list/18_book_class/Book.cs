using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book
{
    public class Book
    {
        public string bookTitle{get;}
        public int bookPages{get;}
        public int bookYearPublished{get;}

        public Book(string title,int pages,int yearPublished)
        {
            this.bookTitle=title;
            this.bookPages=pages;
            this.bookYearPublished=yearPublished;
        }

        public override string ToString()
        {
            return this.bookTitle+", "+this.bookPages+" pages, "+this.bookYearPublished;
        }
    }
}