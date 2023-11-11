using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class GroupAddressee : IAddressee
{
    private readonly Collection<IAddressee> _group = new Collection<IAddressee>();

    public void RecieveMessage(Message message)
    {
        foreach (IAddressee addressee in _group)
            addressee.RecieveMessage(message);
    }
}
