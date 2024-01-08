using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Logger : Addressee
{
    private string? _mode;
    public Logger() { }

    public Logger(Addressee addressee, string mode)
    {
        Addressee = addressee;
        _mode = mode;
    }

    public Addressee? Addressee { get; }

    public static void LogToConsole()
    {
        Console.WriteLine("Message sent");
    }

    public override void ReceiveMessage(Message message)
    {
        Addressee?.ReceiveMessage(message);

        if (_mode == "console")
        LogToConsole();
    }
}
