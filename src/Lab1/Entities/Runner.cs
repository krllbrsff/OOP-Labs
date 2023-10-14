using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Runner
{
    private Runner(Collection<IShip> ships, Collection<IEnvironment> environments)
    {
        Ships = ships;
        Environments = environments;
        ResultsCollection = new Collection<Result>();
    }

    public Collection<Result>? ResultsCollection { get; private set; }
    public Result? Result { get; private set; }
    private Collection<IShip> Ships { get; }
    private Collection<IEnvironment> Environments { get; }
    public void Go()
    {
        foreach (IShip ship in Ships)
        {
            foreach (IEnvironment environment in Environments)
            {
                if (ship?.Deflector != null)
                    Result = ship?.Deflector.TakeDamage(environment);

                if (Result?.FinalMessage is null)
                {
                    Result = ship?.Corpus?.TakeDamage(environment);
                }
                else
                {
                    ResultsCollection?.Add(Result);
                    break;
                }

                switch (environment)
                {
                    case OpenSpace:
                        Result = ship?.ImpulseEngine.AddDistance(environment); break;

                    case IncreasedDensityNebulae:
                        Result = ship?.JumpEngine?.AddDistance(environment); break;

                    case NitrineParticlesNebulae:
                        Result = ship?.ImpulseEngine.AddDistance(environment); break;
                }

                if (Result?.FinalMessage != null)
                {
                    ResultsCollection?.Add(Result);
                    break;
                }
                else
                {
                    Result = new Result().Success();
                    ResultsCollection?.Add(Result);
                }
            }
        }
    }
}