using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppWithSeriallizer.Models
{
    internal class Movie
    {
        public int MovieId {  get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public int MovieYear {  get; set; }

        public Movie(int movieId,string movieName,string movieGenre,int movieYear)
        {
            MovieId = movieId;
            MovieName = movieName;
            MovieGenre = movieGenre;
            MovieYear = movieYear;
        }

        public static string DisplayMovies(List<Movie>movies)
        {
            if(movies.Count == 0)
            {
                return "No movie present!";
            }
            string result = "==================================\n";
            foreach (Movie m in movies)
            {
                result += $"Movie Id: {m.MovieId}\n" +
                    $"Movie Name: {m.MovieName}\n" +
                    $"Movie Gnere: {m.MovieGenre}\n" +
                    $"Movie release year: {m.MovieYear}\n" +
                    $"==================================\n";
            }
            return result;
        }

        public static string ClearAllMovies(List<Movie>movies)
        {
            movies.Clear();
            return "Cleared All Movies!";
        }
    }
}
