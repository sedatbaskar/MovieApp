using Microsoft.EntityFrameworkCore;
using MoiveApi.Persistence.Context;
using MovieApp.Application.Features.Results.MovieResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetMovieQueryResults>> Handle()
        {
            var values = await _context.Movies.ToListAsync();

            return values.Select(x => new GetMovieQueryResults
            {
                MoiveID = x.MoiveID,
                CoverImageurl = x.CoverImageurl,
                CreateYear = x.CreateYear,
                Description = x.Description,
                Duration = x.Duration,
                Status = x.Status,
                Rating = x.Rating,
                ReleaseDate = x.ReleaseDate,
                Title = x.Title
            }).ToList();
        }
    }
}
