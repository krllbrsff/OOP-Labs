using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public class TreeGoTo : ChainLinkBase
{
    public override void Execute(Command request)
    {
        if (request.CommandText?[0] == "tree" && request.CommandText[1] == "goto")
        {
            if (request.CommandText[2].ToCharArray()[1] == ':' && request.CommandText[2].Contains(Connection.GetConnectionPath(), System.StringComparison.Ordinal))
            {
                string[] pathElements = request.CommandText[2][Connection.GetConnectionPath().Length..].Split('\\').Select(item => item + "\\").ToArray();

                foreach (string element in pathElements)
                {
                    Connection.Path.Push(element);
                }
            }
            else
            {
                string[] pathElements = request.CommandText[2].Split('\\').Select(item => item + "\\").ToArray();

                foreach (string element in pathElements)
                {
                    if (element == "..")
                        Connection.Path.Pop();
                    else Connection.Path.Push(element);
                }
            }
        }
        else
        {
            NextLink?.Execute(request);
        }
    }
}
