namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Stella : IShip
{
    public Stella()
    {
        ImpulseEngine = new ImpulseEngineC();
        JumpEngine = new JumpEngineOmega();
        Corpus = new Corpus1();
        Deflector = new Deflector1();
    }

    public IEngine ImpulseEngine { get; init; }
    public IEngine? JumpEngine { get; init; }
    public Deflector? Deflector { get; init; }
    public Corpus Corpus { get; init; }
}
