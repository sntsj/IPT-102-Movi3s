using System;
namespace BSIT3L_Movies.Models
{
    
	public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Overview { get; set; }
        public string Popularity { get; set; }
        public string PosterPath { get; set; }
        public string VoteAverage { get; set; }

    }
}

