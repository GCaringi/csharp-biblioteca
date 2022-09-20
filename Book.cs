using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {
        public int ISBN {get; set;}
        public int Pages {get; set;}

        public Book(string title, int year, string genre, string position, string author_name, string author_surname, int isbn, int pages) : base(title, year, genre, position, author_name, author_surname)
        {
            ISBN = isbn;
            Pages = pages;
        }
    }
}
