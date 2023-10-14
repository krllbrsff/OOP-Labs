using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Tests
{
    public static IEnumerable<object[]> Set1()
    {
        yield return new object[] { new Shuttle(false), new Collection<IEnvironment> { new IncreasedDensityNebulae(120, 0) }, "Ship lost" };
        yield return new object[] { new Avgur(false), new Collection<IEnvironment> { new IncreasedDensityNebulae(120, 0) }, "Ship lost" };
    }

    [Theory]
    [MemberData(nameof(Set1))]
    private void Test1(IShip ship, Collection<IEnvironment> environments, string expectedValue)
    {
        Assert.Equal(expectedValue, new Runner(ship, environments).Run().FinalMessage);
    }
}
