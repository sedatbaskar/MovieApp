using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.CQRSDesignPattern.Queries.MovieQueries
{
   public class GetMovieByIdQuery
    {
        public GetMovieByIdQuery(int moiveID)
        {
            MoiveID = moiveID;
        }

        public int MoiveID { get; set; }
    }
}
