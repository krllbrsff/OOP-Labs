namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal interface IShip
{
    public IEngine ImpulseEngine { get; init; }
    public IEngine? JumpEngine { get; init; }
    public Deflector? Deflector { get; init; }
    public Corpus Corpus { get; init; }
}
