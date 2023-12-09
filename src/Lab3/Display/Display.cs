namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Display : Addressee
{
    public Display(string name, string path)
    {
        Name = name;
        DisplayDriver = new DisplayDriver(path);
    }

    public string Name { get; }
    public DisplayDriver DisplayDriver { get; }

    public override void ReceiveMessage(Message message)
    {
        DisplayDriver.ReceiveMessage(message);
    }
}
