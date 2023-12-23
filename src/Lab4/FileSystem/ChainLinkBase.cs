namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public abstract class ChainLinkBase : IChainLink
{
    protected IChainLink? NextLink { get; set; }
    public void AddNext(IChainLink link)
    {
        if (NextLink is null)
        {
            NextLink = link;
        }
        else
        {
            NextLink.AddNext(link);
        }
    }

    public abstract void Execute(Command request);
}
