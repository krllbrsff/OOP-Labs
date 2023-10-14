namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class FirstLevelCorpus : Corpus
{
    private const int _maxAsteroidCollisions = 1;
    private const int _maxMeteoriteCollisions = 0;
    public FirstLevelCorpus(bool emmiter)
    {
        MaxAsteroidCollisions = _maxAsteroidCollisions;
        MaxMeteoriteCollisions = _maxMeteoriteCollisions;
        HasAntiNitrineEmitter = emmiter;
    }
}
