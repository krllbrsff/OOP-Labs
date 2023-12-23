namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public interface IChainLink
{
    void AddNext(IChainLink link);

    void Execute(Command request);
}
