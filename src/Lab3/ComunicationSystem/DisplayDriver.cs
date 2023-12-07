using System;
using System.IO;
using Crayon;

namespace Itmo.ObjectOrientedProgramming.Lab3;
public class DisplayDriver : Addressee
{
    private string _path;
    private byte _red;
    private byte _green;
    private byte _blue;
    public DisplayDriver(ImportanceLevels filter, string path)
    {
        _path = path;
        ImportanceFilter = filter;
    }

    public override ImportanceLevels ImportanceFilter { get; }

    public override void ReceiveMessage(Message message)
    {
        Console.WriteLine(Output.Rgb(_red, _green, _blue).Text(message?.Title + '\n' + message?.Text));

        var sw = new StreamWriter(_path);
        sw.WriteLine(Output.Rgb(_red, _green, _blue).Text(message?.Title + '\n' + message?.Text));
        sw.Close();
    }

    public void SetColour(byte r, byte g, byte b)
    {
        _red = r;
        _green = g;
        _blue = b;
    }
}
