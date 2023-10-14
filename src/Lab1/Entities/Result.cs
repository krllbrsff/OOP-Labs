namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Result
{
    public Result()
    {
        FinalMessage = null;
    }

    public string? FinalMessage { get; private set; }

    public Result CrewIsDead()
    {
        FinalMessage = "Crew is dead";
        return this;
    }

    public Result OutOfFuel()
    {
        FinalMessage = "Ship lost";
        return this;
    }

    public Result ShipIsDestroyed()
    {
        FinalMessage = "Ship is destroyed";
        return this;
    }

    public Result Success()
    {
        FinalMessage = "Success!";
        return this;
    }
}
