using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public class FileRename : ChainLinkBase
{
    public override void Execute(Command request)
    {
        if (request.CommandText?[0] == "file" && request.CommandText[1] == "rename")
        {
            if (request.CommandText[2].ToCharArray()[1] == ':' && request.CommandText[2].Contains(Connection.GetConnectionPath(), System.StringComparison.Ordinal))
            {
                File.Move(request.CommandText[2], Directory.GetParent(request.CommandText[2])?.FullName + request.CommandText[3], true);
            }
            else
            {
                Stack<string> tmp = Connection.Path;
                string[] pathElements = request.CommandText[2].Split('\\').Select(item => item + "\\").ToArray();

                foreach (string element in pathElements)
                {
                    if (element == "..")
                        Connection.Path.Pop();
                    else Connection.Path.Push(element);
                }

                string source = Connection.GetCurrentPath();
                Connection.Path.Pop();
                Connection.Path.Push(request.CommandText[3]);
                File.Move(source, Connection.GetCurrentPath(), true);

                Connection.Path.Clear();
                foreach (string item in tmp)
                    Connection.Path.Push(item);
            }
        }
        else
        {
            NextLink?.Execute(request);
        }
    }
}
