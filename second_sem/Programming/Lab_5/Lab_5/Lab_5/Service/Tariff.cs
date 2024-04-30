namespace Lab_5.Service;

public enum CargoType
{
    Heavy,
    Light,
    Fragile
}

public class Tariff
{
    public CargoType CargoType { get; }
    public double PricePerInit { get; }

    public Tariff(CargoType cargoType, double pricePerInit)
    {
        CargoType = cargoType;
        PricePerInit = pricePerInit;
    }
}
