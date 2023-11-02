namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class PowerSupply
{
    private PowerSupply() { }

    public string? Name { get; init; }
    public int Power { get; init; }

    public class PowerSupplyBuilder
    {
        private string? name;
        private int power;

        public PowerSupplyBuilder()
        {
        }

        public PowerSupplyBuilder(PowerSupply powerSupply)
        {
            power = powerSupply.Power;
        }

        public PowerSupplyBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public PowerSupplyBuilder SetPower(int power)
        {
            this.power = power;
            return this;
        }

        public PowerSupply Build()
        {
            return new PowerSupply
            {
                Name = name,
                Power = power,
            };
        }
    }
}
