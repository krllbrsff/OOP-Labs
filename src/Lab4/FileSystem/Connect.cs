namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public class Connect : ChainLinkBase
{
    public override void Execute(Command request)
    {
        if (request.CommandText?[0] == "connect")
        {
            Connection.SetConnection(request.CommandText[1]);
        }
        else
        {
            NextLink?.Execute(request);
        }
    }
}
