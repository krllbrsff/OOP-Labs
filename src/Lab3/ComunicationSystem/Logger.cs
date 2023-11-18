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

    public override void ReceiveMessage(Message message)
    {
        if (message != null)
        {
            Addressee?.ReceiveMessage(message);
            Console.WriteLine("Message sent");
        }
    }
}
