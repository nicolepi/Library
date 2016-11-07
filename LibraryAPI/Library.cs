using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public enum RentalTypes
    {
        Book,
        Audio,
        Video
    }
    public static class Library
    {
        #region Properties

        public static string Name { get; set; }
        public static string Address { get; set; }
        
        #endregion
        //delete book property and constructor
        #region Methods
        public static void AddBook(Book book)
        {
            using(var model = new LibraryModel())//open a connection to the database
            {
                //model is the connection
                model.Books.Add(book); //go to the database find the table Books and add a book
                model.SaveChanges(); //save the changes
            }
            //using is for closing connection

           
        }
        public static void PrintBooks()
        {
            using (var model = new LibraryModel())
            {
                foreach (var book in model.Books) // var is a variable 
                {
                    Console.WriteLine("Title: {0}, ISBN: {1}, Price: {2}, Published: {3}", // {} are place holders
                        book.Title, book.ISBN, book.Price, book.PublishedYear); // things to fill in place holders
                }
            }
               
        }
        #endregion
    }
}
