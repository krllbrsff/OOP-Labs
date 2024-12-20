﻿namespace Itmo.ObjectOrientedProgramming.Lab3;
public class Display
{
    public Display(string name, string path)
    {
        Name = name;
        DisplayDriver = new DisplayDriver(path, new Color(0, 0, 0));
    }

    public string Name { get; }
    public DisplayDriver DisplayDriver { get; }

    public void DisplayMessage(Message message)
    {
        DisplayDriver.ReceiveMessage(message);
    }
}
