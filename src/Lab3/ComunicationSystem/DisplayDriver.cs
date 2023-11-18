using Crayon;
namespace Itmo.ObjectOrientedProgramming.Lab3;
public class DisplayDriver : Addressee
{
    private Display _display;
    private byte _red;
    private byte _green;
    private byte _blue;
    public DisplayDriver(string name, ImportanceLevels filter, Display display)
    {
        Name = name;
        _display = display;
        ImportanceFilter = filter;
    }

    public override ImportanceLevels ImportanceFilter { get; }
    public string Name { get; private set; }

    public override void ReceiveMessage(Message message)
    {
        _display.ReceiveMessage(Output.Rgb(_red, _green, _blue).Text(message?.Title + '\n' + message?.Text));
    }

    public void SetColour(byte r, byte g, byte b)
    {
        _red = r;
        _green = g;
        _blue = b;
    }
}
