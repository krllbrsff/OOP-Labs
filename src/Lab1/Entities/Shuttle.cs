namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Shuttle : IShip
{
    public Shuttle()
    {
        ImpulseEngine = new ImpulseEngineC();
        Corpus = new Corpus1();
    }

    public IEngine ImpulseEngine { get; init; }
    public IEngine? JumpEngine { get; init; }
    public Deflector? Deflector { get; init; }
    public Corpus Corpus { get; init; }
}
