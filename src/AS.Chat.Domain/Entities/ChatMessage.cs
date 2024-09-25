using AS.Chat.Domain.SeedWork;

namespace AS.Chat.Domain.Entities;

public class ChatMessage: Entity<ChatMessage>
{
    public Guid UserId { get; protected set; }
    public string Message { get; protected set; }
    public string UserName { get; set; }
    public Guid RoomId { get; set; }
    
    protected ChatMessage() { }

    public ChatMessage(Guid userId, string message, string userName, Guid roomId)
    {
        UserId = userId;
        Message = message;
        UserName = userName;
        RoomId = roomId;
        CreatedAt = DateTime.Now;
    }
}