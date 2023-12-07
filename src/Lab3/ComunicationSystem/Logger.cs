using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Logger : Addressee
{
    public Logger() { }

    public Logger(Addressee addressee)
    {
        Addressee = addressee;
    }

    public Addressee? Addressee { get; }

    public static void LogToConsole()
    {
        Console.WriteLine("Message sent");
    }

    public override void ReceiveMessage(Message message)
    {
        Addressee?.ReceiveMessage(message);
        LogToConsole();
    }
}
