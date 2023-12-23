using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
internal class FileMove : ChainLinkBase
{
    public override void Execute(Command request)
    {
        if (request.CommandText?[0] == "file" && request.CommandText[1] == "move")
        {
            if (request.CommandText[2].ToCharArray()[1] == ':' && request.CommandText[2].Contains(Connection.GetConnectionPath(), System.StringComparison.Ordinal))
            {
                if (request.CommandText[3].ToCharArray()[1] == ':' && request.CommandText[2].Contains(Connection.GetConnectionPath(), System.StringComparison.Ordinal))
                {
                    File.Move(request.CommandText[2], request.CommandText[3]);
                }
                else
                {
                    Stack<string> tmp = Connection.Path;
                    string[] pathElements = request.CommandText[3].Split('\\').Select(item => item + "\\").ToArray();

                    foreach (string element in pathElements)
                    {
                        if (element == "..")
                            Connection.Path.Pop();
                        else Connection.Path.Push(element);
                    }

                    File.Move(request.CommandText[2], Connection.GetCurrentPath());

                    Connection.Path.Clear();
                    foreach (string item in tmp)
                        Connection.Path.Push(item);
                }
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

                string pathFirst = Connection.GetCurrentPath();

                if (request.CommandText[3].ToCharArray()[1] == ':' && request.CommandText[2].Contains(Connection.GetConnectionPath(), System.StringComparison.Ordinal))
                {
                    File.Move(Connection.GetCurrentPath(), request.CommandText[3]);

                    Connection.Path.Clear();
                    foreach (string item in tmp)
                        Connection.Path.Push(item);
                }
                else
                {
                    string[] pathElements2 = request.CommandText[3].Split('\\').Select(item => item + "\\").ToArray();

                    foreach (string element in pathElements2)
                    {
                        if (element == "..")
                            Connection.Path.Pop();
                        else Connection.Path.Push(element);
                    }

                    File.Move(pathFirst, Connection.GetCurrentPath());

                    Connection.Path.Clear();
                    foreach (string item in tmp)
                        Connection.Path.Push(item);
                }
            }
        }
        else
        {
            NextLink?.Execute(request);
        }
    }
}
