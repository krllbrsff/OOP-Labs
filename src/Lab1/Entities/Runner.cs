using System;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Runner
{
    public Runner(IShip ship, Collection<IEnvironment> environments)
    {
        Ship = ship;
        Environments = environments;
    }

    public Result? Result { get; private set; }
    public IShip Ship { get; }
    private Collection<IEnvironment> Environments { get; }
    public Result Run()
    {
        Result = new Result();

        foreach (IEnvironment environment in Environments)
        {
            if (Result is null) throw new ArgumentNullException();

            if (Ship?.Deflector != null && Ship.Deflector.IsAlive())
                Result = Ship.Deflector.TakeDamage(environment);

            if (Result?.FinalMessage is Result.Results.Success)
                Result = Ship?.Corpus?.TakeDamage(environment);
            else break;

            switch (environment)
            {
                case OpenSpace:
                    Result = Ship?.ImpulseEngine.AddDistance(environment); break;

                case IncreasedDensityNebulae:
                    if (Ship?.JumpEngine is null)
                        Result?.OutOfFuel();
                    else
                        Result = Ship?.JumpEngine.AddDistance(environment); break;

                case NitrineParticlesNebulae:
                    Result = Ship?.ImpulseEngine.AddDistance(environment); break;
            }
        }

        if (Result is null) throw new ArgumentNullException();
        return Result;
    }
}
