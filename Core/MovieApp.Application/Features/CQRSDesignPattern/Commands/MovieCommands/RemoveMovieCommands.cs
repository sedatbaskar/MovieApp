using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class RemoveMovieCommands
    {
        public RemoveMovieCommands(int moiveID)
        {
            MoiveID = moiveID;
        }

        public int MoiveID { get; set; }



    }
}
