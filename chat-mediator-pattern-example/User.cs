namespace chat_mediator_pattern_example;

public class User
{
    private string _name;
    private IChatMediator _mediator;

    public User(string name, IChatMediator mediator)
    {
        _name = name;
        _mediator = mediator;
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{_name} received : {message}");
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"{_name} sent : {message}");
        _mediator.SendMessage(message, this);
    }
}