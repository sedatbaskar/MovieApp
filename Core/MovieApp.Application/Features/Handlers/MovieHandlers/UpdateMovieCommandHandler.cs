using MoiveApi.Persistence.Context;
using MovieApp.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {

        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(UpdateMovieCommands commands)
        {
            var value = await _context.Movies.FindAsync(commands.MoiveID);
            value.Status = commands.Status;
            value.Title = commands.Title;
            value.Duration = commands.Duration;
            value.Rating = commands.Rating;
            value.Description = commands.Description;
            value.CreateYear = commands.CreateYear;
            value.CoverImageurl = commands.CoverImageurl;
            value.ReleaseDate = commands.ReleaseDate;
            await _context.SaveChangesAsync();


        }
    }
}
