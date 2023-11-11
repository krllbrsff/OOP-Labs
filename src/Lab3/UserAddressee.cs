using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class UserAddressee : IAddressee
{
    public string Name { get; }
    public void RecieveMessage(Message message)
    {
        Console.WriteLine();
    }
}
