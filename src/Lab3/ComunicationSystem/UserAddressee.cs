using System;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class UserAddressee : Addressee
{
    public UserAddressee() { }

    public Collection<Message> NewMessages { get; } = new Collection<Message>();
    public Collection<Message> Archive { get; } = new Collection<Message>();
    public override void ReceiveMessage(Message message)
    {
        Console.WriteLine(message?.Title + '\n' + message?.Text);
        NewMessages.Add(message ?? throw new ArgumentNullException(nameof(message)));
    }

    public void MarkAsRead(Message message)
    {
        if (NewMessages.Contains(message))
        {
            NewMessages.Remove(message);
            Archive.Add(message);
        }
        else if (Archive.Contains(message))
        {
            throw new ArgumentException("Message is alredy readed");
        }
        else
        {
            throw new ArgumentException("Message is not present");
        }
    }
}
