namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Color
{
    public Color(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public byte Red { get; private set; }
    public byte Green { get; private set; }
    public byte Blue { get; private set; }

    public void SetColour(byte r, byte g, byte b)
    {
        Red = r;
        Green = g;
        Blue = b;
    }
}
