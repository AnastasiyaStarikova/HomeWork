using System.Reflection.Metadata;

namespace Cinema.Entities;

/// <summary>
/// Бронирование
/// </summary>
public class Reserv : IIdName
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public long Id { get; set; }


    /// <summary>
    /// Пользователь
    /// </summary>
    public virtual ICollection<Users> Users { get; set; } = null!;

    /// <summary>
    /// Сеанс
    /// </summary>
    public virtual ICollection<Sessions> Sessions { get; set; } = null!;

    /// <summary>
    /// Количество мест
    /// </summary>

    public int Ticket { get; set; }
}