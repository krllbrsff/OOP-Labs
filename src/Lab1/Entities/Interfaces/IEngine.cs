namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public interface IEngine
{
    public double Fuel { get; }
    public double Distance { get; }
    public double Time { get; }

    public Result AddDistance(IEnvironment environment);
}
