using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class GroupAddressee : Addressee
{
    private readonly Collection<Addressee> _group = new Collection<Addressee>();

    public override void ReceiveMessage(Message message)
    {
        foreach (Addressee addressee in _group)
            addressee.ReceiveMessage(message);
    }
}
