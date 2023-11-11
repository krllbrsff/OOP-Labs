namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Topic
{
    public Topic(string name, IAddressee addressee)
    {
        Name = name;
        Addressee = addressee;
    }

    public string Name { get; }
    public IAddressee Addressee { get; }

    public void Send(Message message)
    {
        Addressee.RecieveMessage(message);
    }
}
