namespace AS.Chat.Domain.Interfaces;

public interface IEntity
{
    Guid Id { get; }
    DateTime CreatedAt { get; }
    void ChangeCreatedAt(DateTime date);
    void ChangeId();
}