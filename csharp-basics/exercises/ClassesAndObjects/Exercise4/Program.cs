using System;

namespace Exercise4
{
    public class Program
    {
        public static void Main()
        {
            var spiderMan = new Movie("SpiderMan", "Marvel");
            var jamesBond = new Movie("James Bond", "Eon Productons", "PG-13");
            var glass = new Movie("Glass", "Buena Vista International", "PG-13");
            var movies = new List<Movie>
            {
                spiderMan,
                jamesBond,
                glass
            };

            var filtered = GetPg(movies.ToArray());

            foreach (var movie in filtered)
            {
                Console.WriteLine($"{movie}");
            }

            Console.ReadKey();
        }

        public static Movie[] GetPg(Movie[] movies)
        {
            var filtered = new List<Movie>();

            foreach (var movie in movies)
            {
                if(movie.Rating == "PG")
                {
                    filtered.Add(movie);
                }
            }

            return filtered.ToArray();
        }
    }
}
