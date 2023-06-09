using Cinema.Entities;
using Cinema.Services.Mapper;

namespace Cinema.Services.Dtos;

public class FilmCreateDto : IMapTo<Film>
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Вес
    /// </summary>
    public double Weight { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime Birth { get; set; }

    /// <summary>
    /// Идентификатор хозяина
    /// </summary>
    public long? PersonId { get; set; }
}