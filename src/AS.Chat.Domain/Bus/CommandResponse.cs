namespace AS.Chat.Domain.Bus;

public class CommandResponse
{
    public bool Success { get; private set; }
    public List<string> Message { get; private set; }
    
    public static CommandResponse Ok()
    {
        return new CommandResponse(true, string.Empty);
    }

    public static CommandResponse Fail(string errorMessage = "")
    {
        return new CommandResponse(false, errorMessage);
    }
    
    public static CommandResponse Fail(Exception exception)
    {
        return new CommandResponse(false, exception.Message);
    }
    
    private CommandResponse(bool isSuccess, string errorMessage)
    {
        Success = isSuccess;
        Message = new List<string> { errorMessage };
    }
}