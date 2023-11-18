using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Display
{
    public Display(string path)
    {
        Path = path;
    }

    public string Path { get; }

    public void ReceiveMessage(string messege)
    {
        Console.WriteLine(messege);

        var sw = new StreamWriter(Path);
        sw.WriteLine(messege);
        sw.Close();
    }
}
