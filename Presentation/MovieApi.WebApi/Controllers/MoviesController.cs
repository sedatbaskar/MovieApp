using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApp.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieApp.Application.Features.Handlers.MovieHandlers;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly CreateMovieCommandHandler _createMovieCommandHandler;
        private readonly GetMovieByIdQueryHandler _getMovieByIdQueryHandler;
        private readonly GetMovieQueryHandler _getMovieQueryHandler;
        private readonly RemoveMovieCommandHandler _removeMovieCommandHandler;
        private readonly UpdateMovieCommandHandler _updateMovieCommandHandler;

        public MoviesController(CreateMovieCommandHandler createMovieCommandHandler,
            GetMovieByIdQueryHandler getMovieByIdQueryHandler, GetMovieQueryHandler
            getMovieQueryHandler, RemoveMovieCommandHandler removeMovieCommandHandler,
            UpdateMovieCommandHandler updateMovieCommandHandler)
        {
            _createMovieCommandHandler = createMovieCommandHandler;
            _getMovieByIdQueryHandler = getMovieByIdQueryHandler;
            _getMovieQueryHandler = getMovieQueryHandler;
            _removeMovieCommandHandler = removeMovieCommandHandler;
            _updateMovieCommandHandler = updateMovieCommandHandler;
        }

        [HttpGet]

        public async Task<IActionResult> MovieList()
        {
            var value = await _getMovieQueryHandler.Handle();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieCommands commands)
        {
            await _createMovieCommandHandler.Handle(commands);
            return Ok("Film ekleme işlemi başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _removeMovieCommandHandler.Handle(new RemoveMovieCommands(id));
            return Ok("Silme işlemi Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> GetMovie(int id)
        {
            var value = await _getMovieByIdQueryHandler.Handle(new GetMovieByIdQuery(id));
            return Ok(value);
        }
    }
}
