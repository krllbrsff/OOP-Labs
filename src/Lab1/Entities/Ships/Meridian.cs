namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Meridian : IShip
{
    public Meridian()
    {
        ImpulseEngine = new ImpulseEngineE();
        Corpus = new SecondLevelCorpus();
        Deflector = new Deflector2();
    }

    public IEngine ImpulseEngine { get; }
    public IEngine? JumpEngine { get; }
    public Deflector? Deflector { get; }
    public Corpus Corpus { get; }
}