using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem;

public static class Connection
{
    private static string? _connectionPath;
    public static Stack<string> Path { get; } = new Stack<string>();

    public static string GetCurrentPath()
    {
        string currentPath = _connectionPath ?? throw new ArgumentNullException("File system is not connected");

        foreach (string item in Path.Reverse())
            currentPath = currentPath + '\\' + item;

        return currentPath;
    }

    public static string GetConnectionPath()
    {
        return _connectionPath ?? throw new ArgumentNullException("File system is not connected");
    }

    public static void SetConnection(string connectionPath)
    {
        _connectionPath = connectionPath;
    }

    public static void RemoveConnection()
    {
        _connectionPath = null;
        Path.Clear();
    }
}
