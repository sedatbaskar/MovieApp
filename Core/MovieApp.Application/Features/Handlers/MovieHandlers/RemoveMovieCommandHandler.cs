using MoiveApi.Persistence.Context;
using MovieApp.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApp.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {

        private readonly MovieContext _context;

        public RemoveMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveMovieCommands command)
        {
            var value = await _context.Movies.FindAsync(command.MoiveID);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
