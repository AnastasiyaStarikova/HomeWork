namespace Cinema.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class Users : IIdName
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Фамилия
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// email
    /// </summary>
    public string Email { get; set; }

}