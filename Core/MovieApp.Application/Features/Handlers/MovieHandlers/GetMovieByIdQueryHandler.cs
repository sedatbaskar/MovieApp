using MoiveApi.Persistence.Context;
using MovieApp.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieApp.Application.Features.Results.MovieResults;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetMovieQueryByIdResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FindAsync(query.MoiveID);

            return new GetMovieQueryByIdResult
            {
                MoiveID = value.MoiveID,    
                Title = value.Title,
                Description = value.Description,
                ReleaseDate = value.ReleaseDate,
                Duration = value.Duration,
                Rating = value.Rating,
                CoverImageurl = value.CoverImageurl
            };
        }
    }
}
