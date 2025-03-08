using MoiveApi.Persistence.Context;
using MovieApi.Domain.Entities;
using MovieApp.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Handlers.CategoryHandlers
{
    class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName
            });

            await _context.SaveChangesAsync();

        }


    }
}
