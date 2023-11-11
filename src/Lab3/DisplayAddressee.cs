using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class DisplayAddressee : IAddressee
{
    public void RecieveMessage(Message message)
    {
        Console.WriteLine(message?.Title);
        Console.WriteLine(message?.Text);
    }
}
