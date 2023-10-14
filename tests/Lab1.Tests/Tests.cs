using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

internal class Tests
{
    public static IEnumerable<object[]> Set1()
    {
        yield return new object[] { new Collection<IShip> { new Shuttle(), new Avgur() }, new Collection<IEnvironment> { new IncreasedDensityNebulae(120, 0) }, new Collection<Result> { new Result() } };
    }
}
