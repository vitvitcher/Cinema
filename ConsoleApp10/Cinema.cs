using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public enum Genre
    {
        Comedy,
        Horror,
        Adventure,
        Drama,
        Action
    }
    class Cinema:IEnumerable
    {
        public Movie[] movies;
        public string adress { get; }
        public Cinema(int moviesCount, string adress)
        {
            movies = new Movie[moviesCount];
            this.adress = adress;
        }
        public void PutMovie(int i, Movie movie)
        {
            movies[i] = movie;
        }
        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }
        public class CompareByRating : IComparer<Movie>
        {
            int IComparer<Movie>.Compare(Movie x, Movie y)
            {
                return x.Rating.CompareTo(y.Rating);
            }
        }
        public class CompareByYear : IComparer<Movie>
        {
            int IComparer<Movie>.Compare(Movie x, Movie y)
            {
                return x.Year.CompareTo(y.Year);
            }
        }
        public void Sort()
        {
            Array.Sort(movies);
        }
    }
}
