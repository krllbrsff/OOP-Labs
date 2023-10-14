namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Vaclas : IShip
{
    public Vaclas()
    {
        ImpulseEngine = new ImpulseEngineE();
        JumpEngine = new JumpEngineGamma();
        Corpus = new SecondLevelCorpus();
        Deflector = new Deflector1();
    }

    public IEngine ImpulseEngine { get; }
    public IEngine? JumpEngine { get; }
    public Deflector? Deflector { get; }
    public Corpus Corpus { get; }
}