using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Messenger
{
    public Messenger(string name, ImportanceLevels filter)
    {
        Name = name;
        ImportanceFilter = filter;
    }

    public string Name { get; }
    public ImportanceLevels ImportanceFilter { get; }
    public void ReceiveMessage(Message message)
    {
        Console.WriteLine(message?.Title + '\n' + message?.Text + "\nvia " + Name);
    }
}