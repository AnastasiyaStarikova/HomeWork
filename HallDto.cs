using Cinema.Entities;
using Cinema.Services.Mapper;

namespace Cinema.Services.Dtos;

public class HallDto : IMapFrom<Hall>
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
    /// Количество мест
    /// </summary>
}