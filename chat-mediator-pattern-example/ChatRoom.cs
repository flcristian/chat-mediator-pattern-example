namespace chat_mediator_pattern_example;

public class ChatRoom : IChatMediator
{
    private List<User> _users;

    public ChatRoom()
    {
        _users = new List<User>();
    }
    
    public ChatRoom(List<User> users)
    {
        _users = users;
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (User user in _users)
        {
            if (!user.Equals(sender)) user.ReceiveMessage(message);
        }
    }
}