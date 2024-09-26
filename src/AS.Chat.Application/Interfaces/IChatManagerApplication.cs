using AS.Chat.Application.Model;

namespace AS.Chat.Application.Interfaces;

public interface IChatManagerApplication : IDisposable
{
    public Task<IEnumerable<ChatRoomDto>> GetChatRooms();
}