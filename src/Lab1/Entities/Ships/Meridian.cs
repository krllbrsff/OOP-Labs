namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Meridian : IShip
{
    public Meridian(bool photonicDeflector)
    {
        ImpulseEngine = new ImpulseEngineE();
        Corpus = new SecondLevelCorpus(true);
        Deflector = new Deflector2(photonicDeflector);
    }

    public IEngine ImpulseEngine { get; }
    public IEngine? JumpEngine { get; }
    public Deflector? Deflector { get; }
    public Corpus Corpus { get; }
}