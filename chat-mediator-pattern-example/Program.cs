using chat_mediator_pattern_example;

internal class Program
{
    public static void Main(string[] args)
    {
        ChatRoom chat = new ChatRoom();
        User george = new User("George", chat);
        User andrei = new User("Andrei", chat);
        User paul = new User("Paul", chat);
        
        chat.AddUser(george);
        chat.AddUser(andrei);
        chat.AddUser(paul);
        
        george.SendMessage("Hello world!");
    }
}