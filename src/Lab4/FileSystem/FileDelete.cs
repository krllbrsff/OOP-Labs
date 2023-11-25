using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
internal class FileDelete : ChainLinkBase
{
    public override void Execute(Command request)
    {
        if (request.CommandText?[0] == "file" && request.CommandText[1] == "delete")
        {
            if (request.CommandText[2].ToCharArray()[1] == ':' && request.CommandText[2].Contains(Connection.GetConnectionPath(), System.StringComparison.Ordinal))
            {
                File.Delete(request.CommandText[2]);
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

                File.Delete(Connection.GetCurrentPath());

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
