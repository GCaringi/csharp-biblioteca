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

        public List<Book> books;

        public List<Dvd> dvds;

        public List<Users> users;

        public Library(string name)
        {
            Name = name;
            books = new List<Book>();
            dvds = new List<Dvd>();
            users = new List<Users>();
        }
    }

    
}
