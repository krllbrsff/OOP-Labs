using System;
using System.IO;
using Crayon;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class DisplayDriver : Addressee
{
    private string _path;
    private Color _color;

    public DisplayDriver(string path, Color color)
    {
        _path = path;
        _color = color;
    }

    public override void ReceiveMessage(Message message)
    {
        Console.WriteLine(Output.Rgb(_color.Red, _color.Green, _color.Blue).Text(message?.Title + '\n' + message?.Text));

        var sw = new StreamWriter(_path);
        sw.WriteLine(Output.Rgb(_color.Red, _color.Green, _color.Blue).Text(message?.Title + '\n' + message?.Text));
        sw.Close();
    }
}
