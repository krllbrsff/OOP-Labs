using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Comparer
{
    public Comparer(Collection<IShip> ships, Collection<IEnvironment> environments)
    {
        Ships = ships;
        Environments = environments;
        SuccessShips = new Collection<IShip>();
    }

    public Collection<IShip> Ships { get; }
    public Collection<IEnvironment> Environments { get; }
    public Collection<IShip> SuccessShips { get; private set; }

    public void SendShips()
    {
        foreach (IShip ship in Ships)
        {
            var currentRun = new Runner(ship, Environments);

            currentRun.Run();

            if (currentRun.Result?.FinalMessage is Result.Results.Success)
            {
                SuccessShips.Add(currentRun.Ship);
            }
        }
    }

    public IShip PickBestShip()
    {
        IShip bestShip = SuccessShips[0];

        foreach (IShip ship in SuccessShips)
        {
            if ((ship.ImpulseEngine.SpentFuel + ship.JumpEngine?.SpentFuel) < (bestShip.ImpulseEngine.SpentFuel + bestShip.JumpEngine?.SpentFuel))
                bestShip = ship;
        }

        return bestShip;
    }
}
