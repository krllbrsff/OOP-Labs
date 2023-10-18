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
        var obstacles = new Collection<IObstacle>();
        obstacles.Add(new Antimatter(1));
        yield return new object[] { new Vaclas(false, false), new Collection<IEnvironment> { new IncreasedDensityNebulae(190, obstacles) }, Result.Results.CrewIsDead };
        yield return new object[] { new Vaclas(false, true), new Collection<IEnvironment> { new IncreasedDensityNebulae(190, obstacles) }, Result.Results.Success };
    }

    [Theory]
    [MemberData(nameof(Set1))]
    private void Test1(IShip ship, Collection<IEnvironment> environments, Result.Results expectedValue)
    {
        Assert.Equal(expectedValue, new Runner(ship, environments).Run().FinalMessage);
    }

    [Theory]
    [MemberData(nameof(Set2))]
    private void Test2(IShip ship, Collection<IEnvironment> environments, Result.Results expectedValue)
    {
        Assert.Equal(expectedValue, new Runner(ship, environments).Run().FinalMessage);
    }
}
