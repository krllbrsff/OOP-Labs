namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Filter : Addressee
{
    private Addressee _addressee;

    public Filter(Addressee userAddressee, ImportanceLevels level)
    {
        _addressee = userAddressee;
        ImportanceFilter = level;
    }

    public ImportanceLevels ImportanceFilter { get; }

    public override void ReceiveMessage(Message message)
    {
        FilterByLevel(message);
    }

    private void FilterByLevel(Message message)
    {
        if (message?.ImportanceFilter >= ImportanceFilter)
        {
            _addressee.ReceiveMessage(message);
        }
    }
}
