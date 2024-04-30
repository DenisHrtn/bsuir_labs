namespace Lab_5.Service;

public class Firm
{
    private List<Tariff> tariffs = new List<Tariff>();
    private List<Client> clients = new List<Client>();

    public void AddTariff(Tariff tariff)
    {
        tariffs.Add(tariff);
    }

    public void RegisterClient(Client client)
    {
        clients.Add(client);
    }

    public void AddOrderToClient(Client client, double volume, CargoType cargoType)
    {
        Order order = new Order(client, volume, cargoType);
        client.AddOrder(order);
    }

    public double CalculateTotalOrderSum()
    {
        double totalSum = 0;
        foreach (var client in clients)
        {
            totalSum += client.CalculateOrderSum();
        }

        return totalSum;
    }

    public double GetPriceOfTariff(CargoType cargoType)
    {
        foreach (var tariff in tariffs)
        {
            if (tariff.CargoType == cargoType)
            {
                return tariff.PricePerInit;
            }
        }

        throw new ArgumentException("No tariff found for the specifed cargo type");
    }
}