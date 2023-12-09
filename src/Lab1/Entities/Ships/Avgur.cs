namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Avgur : IShip
{
    public Avgur(bool emitter, bool photonicDeflector)
    {
        ImpulseEngine = new ImpulseEngineE();
        JumpEngine = new JumpEngineAlpha();
        Corpus = new ThirdLevelCorpus(emitter);
        Deflector = new Deflector3(photonicDeflector);
    }

    public IEngine ImpulseEngine { get; }
    public IEngine JumpEngine { get; }
    public Deflector Deflector { get; }
    public Corpus Corpus { get; }
}
