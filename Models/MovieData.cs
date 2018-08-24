using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebApplication.Models
{
    public class MovieData
    {
        public List<Movie> Getata()
        {
            List<Movie> movie = new List<Movie>
            {
            new Movie { MovieId =1, MovieName ="Titanic", ReleaseYear ="1998" ,Genre ="Romance"},
            new Movie { MovieId =2, MovieName ="Forest Gump", ReleaseYear ="1995",Genre ="Fiction"  },
            new Movie { MovieId =3, MovieName ="Bahubali", ReleaseYear ="2017" ,Genre ="Fiction" },
            new Movie { MovieId =4, MovieName ="The Dark Night", ReleaseYear ="2007",Genre ="Action"  },
            new Movie { MovieId =5, MovieName ="The Shawshank Redemption", ReleaseYear ="1988",Genre ="Fiction"  }
            };
            return movie;
        }
    }
}
