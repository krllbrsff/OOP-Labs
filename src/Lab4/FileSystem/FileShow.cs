using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public class FileShow : ChainLinkBase
{
    public override void Execute(Command request)
    {
        if (request.CommandText?[0] == "file" && request.CommandText[1] == "show")
        {
            if (request.CommandText[2].ToCharArray()[1] == ':' && request.CommandText[2].Contains(Connection.GetConnectionPath(), System.StringComparison.Ordinal))
            {
                string fileContent = File.ReadAllText(request.CommandText[2]);
                Console.WriteLine(fileContent);
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

                string fileContent = File.ReadAllText(Connection.GetCurrentPath());
                Console.WriteLine(fileContent);

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
