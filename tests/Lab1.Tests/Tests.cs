using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Tests
{
    public static IEnumerable<object[]> Set1()
    {
        var obstacles = new Collection<IObstacle>();
        yield return new object[] { new Shuttle(false), new Collection<IEnvironment> { new IncreasedDensityNebulae(120, obstacles) }, Result.Results.OutOfFuel };
        yield return new object[] { new Avgur(false, false), new Collection<IEnvironment> { new IncreasedDensityNebulae(120, obstacles) }, Result.Results.OutOfFuel };
    }

    public static IEnumerable<object[]> Set2()
    {
        var obstacles = new Collection<IObstacle> { new Antimatter(1) };

        yield return new object[] { new Vaclas(false, false), new Collection<IEnvironment> { new IncreasedDensityNebulae(190, obstacles) }, Result.Results.CrewIsDead };
        yield return new object[] { new Vaclas(false, true), new Collection<IEnvironment> { new IncreasedDensityNebulae(190, obstacles) }, Result.Results.Success };
    }

    public static IEnumerable<object[]> Set3()
    {
        var obstacles = new Collection<IObstacle> { new Whale(1) };

        yield return new object[] { new Vaclas(false, false), new Collection<IEnvironment> { new NitrineParticlesNebulae(90, obstacles) }, Result.Results.ShipIsDestroyed };
        yield return new object[] { new Avgur(false, false), new Collection<IEnvironment> { new NitrineParticlesNebulae(90, obstacles) }, Result.Results.Success };
        yield return new object[] { new Meridian(false), new Collection<IEnvironment> { new NitrineParticlesNebulae(90, obstacles) }, Result.Results.Success };
    }

    public static IEnumerable<object[]> Set4()
    {
        var obstacles = new Collection<IObstacle> { new Whale(2), new Meteorite(3), new Asteroid(5) };

        yield return new object[] { new Meridian(false), new Collection<IEnvironment> { new OpenSpace(50, obstacles), new NitrineParticlesNebulae(90, obstacles) }, Result.Results.Success };
    }

    [Theory]
    [MemberData(nameof(Set1))]
    private void MediumLengthIncreasedDensityNebulae(IShip ship, Collection<IEnvironment> environments, Result.Results expectedValue)
    {
        Assert.Equal(expectedValue, new Runner(ship, environments).Run().FinalMessage);
    }

    [Theory]
    [MemberData(nameof(Set2))]
    private void AntimatterInIncreasedDensityNebulae(IShip ship, Collection<IEnvironment> environments, Result.Results expectedValue)
    {
        Assert.Equal(expectedValue, new Runner(ship, environments).Run().FinalMessage);
    }

    [Theory]
    [MemberData(nameof(Set3))]
    private void WhaleInNitrineParticlesNebulae(IShip ship, Collection<IEnvironment> environments, Result.Results expectedValue)
    {
        Assert.Equal(expectedValue, new Runner(ship, environments).Run().FinalMessage);
    }

    [Fact]
    private void ShortLengthOpenSpace()
    {
        var ships = new Collection<IShip> { new Shuttle(false), new Vaclas(false, false) };
        var environments = new Collection<IEnvironment> { new OpenSpace(30, new Collection<IObstacle>()) };
        var currentRun = new Comparer(ships, environments);

        currentRun.SendShips();

        Assert.True(currentRun.PickBestShip() is Shuttle);
    }

    [Fact]
    private void StellaAndAvgurInIncreasedDensityNebulae()
    {
        var ships = new Collection<IShip> { new Avgur(false, false), new Stella(false, false) };
        var environments = new Collection<IEnvironment> { new IncreasedDensityNebulae(140, new Collection<IObstacle>()) };
        var currentRun = new Comparer(ships, environments);

        currentRun.SendShips();

        Assert.True(currentRun.PickBestShip() is Stella);
    }

    [Fact]
    private void ShuttleAndVaclasInNitrineParticlesNebulae()
    {
        var ships = new Collection<IShip> { new Shuttle(false), new Vaclas(false, false) };
        var environments = new Collection<IEnvironment> { new NitrineParticlesNebulae(80, new Collection<IObstacle>()) };
        var currentRun = new Comparer(ships, environments);

        currentRun.SendShips();

        Assert.True(currentRun.PickBestShip() is Vaclas);
    }

    [Theory]
    [MemberData(nameof(Set4))]
    private void MaxDamagedMeridian(IShip ship, Collection<IEnvironment> environments, Result.Results expectedValue)
    {
        Assert.Equal(expectedValue, new Runner(ship, environments).Run().FinalMessage);
    }
}