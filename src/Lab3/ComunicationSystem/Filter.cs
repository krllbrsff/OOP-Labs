namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Filter : Addressee
{
    private Addressee _addressee;

    public Filter(Addressee userAddressee)
    {
        _addressee = userAddressee;
    }

    public override void ReceiveMessage(Message message)
    {
        if (message?.ImportanceFilter >= _addressee.ImportanceFilter)
        {
            _addressee.ReceiveMessage(message);
        }
    }
}
