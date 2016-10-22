using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    /// <summary>
    /// Definition of a book
    /// </summary>
    
    public class Book
    {
        #region Properties 
        /// <summary>
        /// ISBN of the book
        /// </summary>
        [Key] //mark this as a primary key in the database table
        public int ISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        //
        [ForeignKey("Author")]//Author should matach table name, tell entiry framework not to create column
        public int AuthorId { get; set; }//foreign key

        //create one to many relationship
        public virtual Author Author { get; set; } 
        //virtual: virtual relationship, not physically present in Book class
        //the first Author is the table 
        //the second Author is the name of the column
        //created internally by entity framework


        #endregion

        #region Methods 
        //there's a hidden Book constructor
        public void Checkout()
        {
            Count--; //Count = Count - 1;
        }
        public void Return()
        {
            Count++;
        }
        #endregion

    }
}
