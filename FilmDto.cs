using Cinema.Entities;
using Cinema.Services.Mapper;

namespace Cinema.Services.Dtos;

public class FilmDto : IMapFrom<Film>
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Год выпуска
    /// </summary>
    public double ReleaseYear { get; set; }

    /// <summary>
    /// Режиссер
    /// </summary>

    public string Director { get; set; }

    /// <summary>
    /// Жанр
    /// </summary>
    public string Genre { get; set; }

    /// <summary>
    /// Продолжительность
    /// </summary>
    public float Duration { get; set; }

    /// <summary>
    /// Рейтинг
    /// </summary>
    public float Rating { get; set; }
    public HallDto Hall { get; set; }
}