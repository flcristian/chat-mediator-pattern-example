namespace chat_mediator_pattern_example;

public interface IChatMediator
{
    void SendMessage(string message, User sender);
}