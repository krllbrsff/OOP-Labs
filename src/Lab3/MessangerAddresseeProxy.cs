using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class MessangerAddresseeProxy : IAddressee
{
    private MessangerAddressee _messanger;

    public MessangerAddresseeProxy(MessangerAddressee messanger)
    {
        _messanger = messanger;
    }

    public void RecieveMessage(Message message)
    {
        _messanger.RecieveMessage(message);
        Console.WriteLine("Message sended to messanger");
    }
}
