using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Movie
    {
        private string _title;
        private string _studio;
        public string Rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            Rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            Rating = "PG";
        }

        public override string ToString()
        {
            return $"{_title}, {_studio}, {Rating}";
        }

    }
}
