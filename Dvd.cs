using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        public int Serial { get; set; }
        public int Duration { get; set; }

        public Dvd(string title, int year, string genre, string position, string author_name, string author_surname, int serial, int duration) : base(title, year, genre, position, author_name, author_surname)
        {
            Serial = serial;
            Duration = duration;
        }
    }
}
