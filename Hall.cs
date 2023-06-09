namespace Cinema.Entities;

/// <summary>
/// Кинозалы
/// </summary>
public class Hall : IIdName
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

    public int Seats { get; set; }
}