using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Movie:ICloneable,IComparable
    {
        public string Title { get; }
        public Director director { get; }
        public string Country { get; }
        Genre genre { get; }
        public int Year { get; }
        public short Rating { get; }

        public Movie(string title, Director director,string country, Genre genre, int year, short rating)
        {
            Title = title;
            this.director = director;
            Country = country;
            this.genre = genre;
            Year = year;
            Rating = rating;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Movie otherMovie = obj as Movie;
            if (otherMovie!= null)
            {
                return this.Rating.CompareTo(otherMovie.Rating);
            }
            else
            {
                throw new ArgumentException("Objest is not a movie");
            }
        }
        public object Clone()
        {
            return new Movie(Title, director, Country,genre, Year, Rating);
        }
        public override string ToString()
        {
            return $"-{Title}-\n\nMade by:\n{director.FirstName} {director.LastName}\n\nCountry: {Country}\nGenre: {genre}\nYear: {Year}\nRating: {Rating}";
        }
    }
}
