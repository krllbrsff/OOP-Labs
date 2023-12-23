namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public class Chain : ChainLinkBase
{
    public override void Execute(Command request)
    {
        NextLink?.Execute(request);
    }
}
