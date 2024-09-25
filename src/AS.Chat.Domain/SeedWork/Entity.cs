using AS.Chat.Domain.Interfaces;

namespace AS.Chat.Domain.SeedWork;

public abstract class Entity<T>: IEntity where T:IEntity
{
    public Guid Id { get; protected set; }
    public DateTime CreatedAt { get; protected set; }
    
    protected Entity() => Id = Guid.NewGuid();
}