using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3InheritanceAccesModifiersAutoPropStatic.Exercise5
{
    class Library
    {
        private List<Person> clientsOfTheLibrary;
        private List<Book> booksFromTheLibrary;

        public Library()
        {
            clientsOfTheLibrary = new List<Person>();
            booksFromTheLibrary = new List<Book>();
        }

        public List<Person> ClientsOfTheLibrary { get; set; }
        public List<Book> BooksFromTheLibrary { get; set; }

        public void RegisterPerson(Person person)
        {
            clientsOfTheLibrary.Add(person);
        }

        public void RegisterBook(Book book)
        {
            booksFromTheLibrary.Add(book);
        }
    }
}
