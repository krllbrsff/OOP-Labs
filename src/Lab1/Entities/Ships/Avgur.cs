namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class Avgur : IShip
{
    public Avgur()
    {
        ImpulseEngine = new ImpulseEngineE();
        JumpEngine = new JumpEngineAlpha();
        Corpus = new ThirdLevelCorpus();
        Deflector = new Deflector3();
    }

    public IEngine ImpulseEngine { get; }
    public IEngine? JumpEngine { get; }
    public Deflector? Deflector { get; }
    public Corpus Corpus { get; }
}
