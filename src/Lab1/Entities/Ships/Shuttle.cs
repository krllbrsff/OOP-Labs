namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Shuttle : IShip
{
    public Shuttle(bool emitter)
    {
        ImpulseEngine = new ImpulseEngineC();
        Corpus = new FirstLevelCorpus(emitter);
        Deflector = null;
        JumpEngine = null;
    }

    public IEngine ImpulseEngine { get; }
    public IEngine? JumpEngine { get; }
    public Deflector? Deflector { get; }
    public Corpus Corpus { get; }
}
