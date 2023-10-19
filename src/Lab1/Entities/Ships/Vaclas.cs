namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Vaclas : IShip
{
    public Vaclas(bool emitter, bool photonicDeflector)
    {
        ImpulseEngine = new ImpulseEngineE();
        JumpEngine = new JumpEngineGamma();
        Corpus = new SecondLevelCorpus(emitter);
        Deflector = new Deflector1(photonicDeflector);
    }

    public IEngine ImpulseEngine { get; }
    public IEngine JumpEngine { get; }
    public Deflector Deflector { get; }
    public Corpus Corpus { get; }
}