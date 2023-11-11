using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class UserAddresseeProxy : IAddressee
{
    private UserAddressee _userAddressee;

    public UserAddresseeProxy(UserAddressee userAddressee)
    {
        _userAddressee = userAddressee;
    }

    public void RecieveMessage(Message message)
    {
        if (message?.ImportanceLevel >= _userAddressee.Recipient.Importancelevel)
        {
            _userAddressee.RecieveMessage(message);
            Console.WriteLine("Message sended");
        }
    }
}
