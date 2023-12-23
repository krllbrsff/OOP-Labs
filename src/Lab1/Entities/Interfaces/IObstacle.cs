namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public interface IObstacle
{
    public int Quantity { get; }

    public void DecreaseQuantity();
}
