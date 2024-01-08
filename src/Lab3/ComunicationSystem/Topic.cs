namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Topic
{
    public Topic(string name, Addressee addressee)
    {
        Name = name;
        Addressee = addressee;
    }

    public string Name { get; }
    public Addressee Addressee { get; }

    public void Send(Message message)
    {
        Addressee.ReceiveMessage(message);
    }
}
