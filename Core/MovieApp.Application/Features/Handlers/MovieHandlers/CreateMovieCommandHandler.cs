using Microsoft.EntityFrameworkCore;
using MoiveApi.Persistence.Context;
using MovieApi.Domain.Entities;
using MovieApp.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MovieApp.Application.Features.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _contex;

        public CreateMovieCommandHandler(MovieContext contex)
        {
            _contex = contex;
        }

        public async void Handle(CreateMovieCommands commands)
        {
            _contex.Movies.Add(new Movie
            {
                CoverImageurl = commands.CoverImageurl,
                CreateYear = commands.CreateYear,
                Description = commands.Description,
                Rating = commands.Rating,
                ReleaseDate = commands.ReleaseDate,
                Status = commands.Status,
                Duration = commands.Duration,
                Title = commands.Title,

            });
            await _contex.SaveChangesAsync();
        }
    }
}
