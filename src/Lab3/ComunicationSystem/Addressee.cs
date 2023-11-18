namespace Itmo.ObjectOrientedProgramming.Lab3;
public abstract class Addressee
{
    public virtual ImportanceLevels ImportanceFilter { get; }
    public abstract void ReceiveMessage(Message message);
}
