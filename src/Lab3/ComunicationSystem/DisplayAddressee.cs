namespace Itmo.ObjectOrientedProgramming.Lab3;

public class DisplayAddressee : Addressee
{
    private Display _display;

    public DisplayAddressee(Display display)
    {
        _display = display;
    }

    public override void ReceiveMessage(Message message)
    {
        _display.DisplayMessage(message);
    }
}
