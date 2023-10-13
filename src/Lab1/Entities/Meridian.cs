namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Meridian : IShip
{
    public Meridian()
    {
        ImpulseEngine = new ImpulseEngineE();
        Corpus = new Corpus2();
        Deflector = new Deflector2();
    }

    public IEngine ImpulseEngine { get; init; }
    public IEngine? JumpEngine { get; init; }
    public Deflector? Deflector { get; init; }
    public Corpus Corpus { get; init; }
}