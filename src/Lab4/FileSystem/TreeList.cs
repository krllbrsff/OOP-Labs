using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public class TreeList : ChainLinkBase
{
    public override void Execute(Command request)
    {
        if (request.CommandText?[0] == "tree" && request.CommandText[1] == "list")
        {
            if (request.CommandText.ElementAtOrDefault(2) == "-d")
            {
                Print(Connection.GetCurrentPath(), 1, int.Parse(request.CommandText[3], CultureInfo.InvariantCulture));
            }
            else
            {
                Print(Connection.GetCurrentPath(), 1, 1);
            }
        }
        else
        {
            NextLink?.Execute(request);
        }
    }

    private static void Print(string root, int depth, int maxDepth)
    {
        if (depth <= maxDepth)
        {
            string[] files = Directory.GetFiles(root);
            string[] directories = Directory.GetDirectories(root);

            foreach (string file in files)
            {
                Console.WriteLine(new string(' ', depth) + Path.GetFileName(file));
            }

            foreach (string directory in directories)
            {
                Console.WriteLine(new string(' ', depth) + Path.GetFileName(directory));
                Print(directory, depth + 1, maxDepth);
            }
        }
    }
}