namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Display : Addressee
{
    public Display(string name, string path, ImportanceLevels filter)
    {
        Name = name;
        DisplayDriver = new DisplayDriver(filter, path);
    }

    public string Name { get; }
    public DisplayDriver DisplayDriver { get; }

    public override void ReceiveMessage(Message message)
    {
        DisplayDriver.ReceiveMessage(message);
    }
}
