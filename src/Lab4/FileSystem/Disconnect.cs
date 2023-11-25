namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public class Disconnect : ChainLinkBase
{
    public override void Execute(Command request)
    {
        if (request.CommandText?[0] == "disconnect")
            Connection.RemoveConnection();
        else NextLink?.Execute(request);
    }
}
