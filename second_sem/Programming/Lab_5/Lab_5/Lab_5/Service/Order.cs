namespace Lab_5.Service;

public class Order
{
    public Client Client { get; }
    public double Volume { get; }
    public CargoType CargoType { get; }

    public Order(Client client, double volume, CargoType cargoType)
    {
        Client = client;
        Volume = volume;
        CargoType = cargoType;
    }
}
