using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] movieTitles = { "Cigarette Ki Tarah", "Login", "Bumboo", "Tutiya Dill", "Barfi!" };
            string[] directorFirstNames = { "May", "Michael", "Andrea", "Ben", "Robert" };
            string[] directorLastNames = { "Ledger", "Anderson", "Mario", "Bergman", "Bird" };

            //int.TryParse( Console.ReadLine(),out int count);
            int count = 5;
            Cinema cinema = new Cinema(count, "Movieyna");
            for (int i = 0; i < count;i++)
            {
                //Genre genre = (Genre)typeof(Genre).GetEnumValues().GetValue(rand.Next(0, 4));
                Genre genre = (Genre)rand.Next(0, 5);
                Director director = new Director(directorFirstNames[rand.Next(0, 5)], directorLastNames[rand.Next(0, 5)]);
                Movie movie = new Movie(movieTitles[i], director, "Movieside " + (i + 1), genre, rand.Next(1997, 2015), (short)rand.Next(1,6));
                cinema.PutMovie(i, movie);
            }
            foreach(var movie in cinema.movies)
            {
                Console.WriteLine( movie.toString());
                Console.WriteLine(string.Concat(Enumerable.Repeat("-",20)));
            }
        }
    }
}
