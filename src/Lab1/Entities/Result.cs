namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Result
{
    public Result()
    {
        FinalMessage = Results.Success;
    }

    public enum Results
    {
        CrewIsDead,
        OutOfFuel,
        ShipIsDestroyed,
        Success,
        DeflectorIsDestroyed,
    }

    public Results FinalMessage { get; private set; }

    public Result CrewIsDead()
    {
        FinalMessage = Results.CrewIsDead;
        return this;
    }

    public Result OutOfFuel()
    {
        FinalMessage = Results.OutOfFuel;
        return this;
    }

    public Result ShipIsDestroyed()
    {
        FinalMessage = Results.ShipIsDestroyed;
        return this;
    }

    public Result Success()
    {
        FinalMessage = Results.Success;
        return this;
    }
}
