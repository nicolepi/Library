using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book(); //new key word calls a constructor to allocate space for Book
            book.Title = "Intro to CS";
            book.ISBN = 1234567;
            book.Price = 12.34M;
            book.Count = 5;
            book.PublishedYear = new DateTime(2010, 1, 1);

            Library.AddBook(book);

            book = new Book(); // reuse the book to save memory
            book.Title = "Intro to C#";
            book.ISBN = 1234534367;
            book.Price = 50.34M;
            book.Count = 10;
            book.PublishedYear = new DateTime(2010, 1, 1);

            Library.AddBook(book);

            Library.PrintBooks();
        }
    }
}
