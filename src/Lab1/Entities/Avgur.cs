namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Avgur : IShip
{
    public Avgur()
    {
        ImpulseEngine = new ImpulseEngineE();
        JumpEngine = new JumpEngineAlpha();
        Corpus = new Corpus3();
        Deflector = new Deflector3();
    }

    public IEngine ImpulseEngine { get; init; }
    public IEngine? JumpEngine { get; init; }
    public Deflector? Deflector { get; init; }
    public Corpus Corpus { get; init; }
}
