namespace Lab_5.Service;

public class Client
{
    public string Name { get; }
    public List<Order> Orders { get; } = new List<Order>();

    public Client(string name)
    {
        Name = name;
    }

    public void AddOrder(Order order)
    {
        Orders.Add(order);
    }

    public double CalculateOrderSum()
    {
        double sum = 0;
        foreach (var order in Orders)
        {
            sum += order.Volume * Program.Firm.GetPriceOfTariff(order.CargoType);
        }

        return sum;
    }
}
