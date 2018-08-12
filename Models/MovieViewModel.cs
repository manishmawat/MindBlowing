using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindBlowing.Models
{
    public class MovieViewModel
    {
        public List<Movie> listOFMovies;
        public MovieViewModel(/*int moviewID,string movieName*/)
        {
            listOFMovies = new List<Movie>()
            {
                new Movie(){ MoviewId=1,MovieName="Lagaan"},
                new Movie(){ MoviewId=2,MovieName="3 Idiot" }
            };
        }
    }
}