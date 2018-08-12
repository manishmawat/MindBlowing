using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindBlowing.Models
{
    public class MovieDetailsViewModel
    {
        public Movie movie;
        public MovieDetailsViewModel(int movieID,string movieName)
        {
            movie = new Movie();
            movie.MoviewId = movieID;
            movie.MovieName = movieName;
        }
    }
}