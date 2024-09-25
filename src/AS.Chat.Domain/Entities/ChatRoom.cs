using AS.Chat.Domain.SeedWork;

namespace AS.Chat.Domain.Entities;

public class ChatRoom: Entity<ChatRoom>
{
    public string Name { get; set; }
    
    protected ChatRoom() { }
 
    public ChatRoom(string name)
    {
        Name = name;
    }
}