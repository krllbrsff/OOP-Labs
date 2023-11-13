namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class PowerSupply
{
    private PowerSupply() { }

    public string? Name { get; init; }
    public int Power { get; init; }

    public class PowerSupplyBuilder
    {
        private string? _name;
        private int _power;

        public PowerSupplyBuilder()
        {
        }

        public PowerSupplyBuilder(PowerSupply powerSupply)
        {
            _power = powerSupply.Power;
        }

        public PowerSupplyBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public PowerSupplyBuilder SetPower(int power)
        {
            _power = power;
            return this;
        }

        public PowerSupply Build()
        {
            return new PowerSupply
            {
                Name = _name,
                Power = _power,
            };
        }
    }
}
