using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Cinema.Entities;
using Cinema.Infrastructure;
using Cinema.Services.Dtos;

namespace Cinema.Services;

public interface IFilmService
{
    Task<List<FilmDto>> GetAll();
    Task<long> Create(FilmCreateDto dto);
}

public class FilmService : IFilmService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public FilmService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public Task<List<FilmDto>> GetAll()
    {
        return _dbContext.Films.ProjectTo<FilmDto>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public async Task<long> Create(FilmCreateDto dto)
    {
        var entity = _mapper.Map<Film>(dto);
        _dbContext.Films.Add(entity);
        await _dbContext.SaveChangesAsync();

        return entity.Id;
    }

    Task<long> IFilmService.Create(FilmCreateDto dto)
    {
        throw new NotImplementedException();
    }
}