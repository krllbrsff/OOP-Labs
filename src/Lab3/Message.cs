namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Message
{
    public Message(string title, string text)
    {
        Title = title;
        Text = text;
    }

    public string Title { get; }
    public string Text { get; }
    public Importancelevels ImportanceLevel { get; }
}
