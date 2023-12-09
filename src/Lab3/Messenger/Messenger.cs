using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Messenger
{
    public Messenger(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public void ReceiveMessage(Message message)
    {
        Console.WriteLine(message?.Title + '\n' + message?.Text + "\nvia " + Name);
    }
}