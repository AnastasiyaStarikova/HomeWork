using Microsoft.AspNetCore.Mvc;
using Cinema.Services;
using Cinema.Services.Dtos;

namespace Cinema.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        private readonly IFilmService _service;

        public Controller(IFilmService service)
        {
            _service = service;
        }

        [HttpGet()]
        public Task<List<FilmDto>> Get()
        {
            return _service.GetAll();
        }

        [HttpPost()]
        public Task<long> Create([FromBody] FilmCreateDto dto)
        {
            return _service.Create(dto);
        }
    }
}