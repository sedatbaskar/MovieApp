using MoiveApi.Persistence.Context;
using MovieApp.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Handlers.CategoryHandlers
{



    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveCategoryCommand command)
        {
            var value = await _context.Movies.FindAsync(command.CategoryId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
