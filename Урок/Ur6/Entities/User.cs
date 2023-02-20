namespace VpuDotnet.Entities;
// интерфейс все сущности 
public class User : IEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } // время создания 
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }
    public string? FullName { get; set; }
}