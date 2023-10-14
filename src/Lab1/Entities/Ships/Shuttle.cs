namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Shuttle : IShip
{
    public Shuttle()
    {
        ImpulseEngine = new ImpulseEngineC();
        Corpus = new FirstLevelCorpus();
    }

    public IEngine ImpulseEngine { get; }
    public IEngine? JumpEngine { get; }
    public Deflector? Deflector { get; }
    public Corpus Corpus { get; }
}
