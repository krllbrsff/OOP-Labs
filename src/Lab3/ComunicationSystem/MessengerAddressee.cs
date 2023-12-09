namespace Itmo.ObjectOrientedProgramming.Lab3;
public class MessengerAddressee : Addressee
{
    private Messenger _messenger;
    public MessengerAddressee(Messenger messenger)
    {
        _messenger = messenger;
    }

    public override void ReceiveMessage(Message message)
    {
        _messenger.ReceiveMessage(message);
    }
}
