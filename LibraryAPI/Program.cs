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
            Console.WriteLine("Welcome to my Library!");
            int choice = -1; //create an output parameter to be used below in while and out parameter
            bool invalidChoice = false;
            while (choice != 0 || invalidChoice)
            {
                Console.WriteLine("1. Add a book to the library.");
                Console.WriteLine("2. Rent a book from the Library");
                Console.WriteLine("3. Return a book.");
                Console.WriteLine("0. Exit.");
                Console.Write("Please choose an option: ");
                var input = Console.ReadLine();
                //convert input from string to int

                if (!int.TryParse(input, out choice))
                {
                    invalidChoice = true;
                    Console.WriteLine("Invalid choice, try again...");
                    continue;
                }
                invalidChoice = false; //resest it when it didn't go thru if condition
                switch (choice)
                {
                    case 1:
                        Console.Write("Title: ");
                        var title = Console.ReadLine();
                        Console.Write("Price: ");
                        decimal price;
                        if(!decimal.TryParse(Console.ReadLine(), out price))
                            return;
                        var book = new Book();
                        book.Title = title;
                        book.Price = price;
                        book.PublishedYear = DateTime.Now;
                        book.AuthorId = 1;
                        Library.AddBook(book);                 

                        break;
                    case 2:

                        
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
            

            Library.PrintBooks();
        }
    }
}
