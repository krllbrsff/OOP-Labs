namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Vaclas : IShip
{
    public Vaclas()
    {
        ImpulseEngine = new ImpulseEngineE();
        JumpEngine = new JumpEngineGamma();
        Corpus = new Corpus2();
        Deflector = new Deflector1();
    }

    public IEngine ImpulseEngine { get; init; }
    public IEngine? JumpEngine { get; init; }
    public Deflector? Deflector { get; init; }
    public Corpus Corpus { get; init; }
}