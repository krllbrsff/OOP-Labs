namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class ThirdLevelCorpus : Corpus
{
    private const int _maxAsteroidCollisions = 20;
    private const int _maxMeteoriteCollisions = 5;
    public ThirdLevelCorpus(bool emmiter)
    {
        MaxAsteroidCollisions = _maxAsteroidCollisions;
        MaxMeteoriteCollisions = _maxMeteoriteCollisions;
        HasAntiNitrineEmitter = emmiter;
    }
}
