using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public class FileCopy : ChainLinkBase
{
    public override void Execute(Command request)
    {
        if (request.CommandText?[0] == "file" && request.CommandText[1] == "copy")
        {
            if (request.CommandText[2].ToCharArray()[1] == ':' && request.CommandText[2][0..Connection.GetConnectionPath().Length] == Connection.GetConnectionPath())
            {
                if (request.CommandText[3].ToCharArray()[1] == ':' && request.CommandText[2][0..Connection.GetConnectionPath().Length] == Connection.GetConnectionPath())
                {
                    File.Copy(request.CommandText[2], request.CommandText[3]);
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

                    File.Copy(request.CommandText[2], Connection.GetCurrentPath());

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
                    File.Copy(Connection.GetCurrentPath(), request.CommandText[3]);

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

                    File.Copy(pathFirst, Connection.GetCurrentPath());

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
