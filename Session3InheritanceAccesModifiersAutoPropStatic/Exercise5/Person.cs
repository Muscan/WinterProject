using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3InheritanceAccesModifiersAutoPropStatic.Exercise5
{
    class Person
    {
        private string personName;
        private List<Book> booksRented;

        public Person(string personName)
        {
            this.personName = personName;
            //Instantiate an empty list so that I can add/delete books after I add them
            booksRented = new List<Book>();
        }

        public string PersonName { get; set; }
        public List<Book> BooksRented { get; set; }

        //PersonBorrow
        public void Borrow(Book book)
        {
            //check if the book is available first
            if (book.BookAvailable == true)
            {
                booksRented.Add(book);
                book.BookAvailable = false;
            }
            else
            {
                Console.WriteLine("Book not available ");
            }

        }

        //return  book
        public void ReturnBook(Book book)
        {
            //check if the book is rented by the specific person
            if (booksRented.Contains(book))
            {
                booksRented.Remove(book);
                book.BookAvailable = true;
            }
            else
            {
                Console.WriteLine("Book was  not rented by this person ");
            }
        }
        //Print all books rented by the person

        public void PrintBooksRentedByThePerson()
        {
            for (int i = 0; i < booksRented.Count; i++)
            {
                Console.WriteLine(booksRented[i].ToString());
            }
        }
    }
}