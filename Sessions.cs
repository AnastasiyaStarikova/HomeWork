using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Entities;

/// <summary>
/// Сеанс
/// </summary>
public class Sessions : IIdName
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Фильмы
    /// </summary>
    public virtual ICollection<Film> Films { get; set; } = null!;
    /// <summary>
    /// Кинозалы
    /// </summary>
    public virtual ICollection<Hall> Halls { get; set; } = null!;
    /// <summary>
    /// Дата и время сеанса
    /// </summary>
    public DateTime Date { get; set; }
}