namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Stella : IShip
{
    public Stella(bool emitter, bool photonicDeflector)
    {
        ImpulseEngine = new ImpulseEngineC();
        JumpEngine = new JumpEngineOmega();
        Corpus = new FirstLevelCorpus(emitter);
        Deflector = new Deflector1(photonicDeflector);
    }

    public IEngine ImpulseEngine { get; }
    public IEngine? JumpEngine { get;    }
    public Deflector? Deflector { get; }
    public Corpus Corpus { get; }
}
