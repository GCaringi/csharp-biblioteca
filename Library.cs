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

        private List<Document> _documents;

        public Library(string name)
        {
            Name = name;
            _books = new List<Book>();
            _dvds = new List<Dvd>();
            _users = new List<Users>();
            _documents = new List<Document>();
        }

        public void allDoc()
        {
            if (_documents.Count() == 0)
            {
                Console.WriteLine("Non c'è nulla nella libreria");
            }
            else
            {
                Console.WriteLine("Lista dei Documenti");
                foreach (Document doc in _documents)
                {
                    Console.WriteLine(doc.Title);
                }
            }
        }

        public void AddDocument(Document doc)
        {
            _documents.Add(doc);
        }

        public void RegisterUser(Users user)
        {
            _users.Add(user);
        }

    }

    
}
