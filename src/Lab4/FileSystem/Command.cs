using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
public record Command
{
    public IList<string>? CommandText { get; private set; }

    private static string[] Parse(string command)
    {
        return command.Split(' ');
    }

    public void SetNewCommand(string command)
    {
        CommandText = Parse(command);
    }
}
