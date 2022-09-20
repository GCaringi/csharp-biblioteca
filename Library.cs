using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {
        public string Name { get; }

        private List<Book> _books;

        private List<Dvd> _dvds;

        private List<Users> _users;

        public Library(string name)
        {
            Name = name;
            _books = new List<Book>();
            _dvds = new List<Dvd>();
            _users = new List<Users>();
        }

        public void allCatalog()
        {
            if (_books.Count == 0)
            {
                Console.WriteLine("Non sono presenti libri");
            }
            else
            {
                Console.WriteLine("Lista Libri");
                foreach (Book book in _books)
                {
                    Console.WriteLine($"{book.Title}");
                }
            }
            if (_dvds.Count == 0)
            {
                Console.WriteLine("Non sono presenti dvd");

            }
            else
            {
                Console.WriteLine("Lista DVD");
                foreach(Dvd dvd in _dvds)
                {
                    Console.WriteLine($"{dvd.Title}");
                }
            }
        }

        public void AddBook(string title, int year, string genre, string position, string author_name, string author_surname, int isbn, int pages)
        {
            _books.Add(new Book(title, year, genre, position, author_name, author_surname, isbn, pages));
        }

        public void AddDvd(string title, int year, string genre, string position, string author_name, string author_surname, int duration, int serial)
        {
            _dvds.Add(new Dvd(title, year, genre, position, author_name, author_surname, serial, duration));
        }

        public void RegisterUser(string name, string surname, string email, string password, string phoneNumber)
        {
            _users.Add(new Users(name, surname, email, password, phoneNumber));
        }

    }

    
}
