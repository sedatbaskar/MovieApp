using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Results.MovieResults
{
    public class GetMovieQueryResults
    {
        public int MoiveID { get; set; }
        public string Title { get; set; }
        public string CoverImageurl { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CreateYear { get; set; }
        public bool Status { get; set; }
    }
}
