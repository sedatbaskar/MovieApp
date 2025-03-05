using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class CreateMovieCommands
    {
        
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
