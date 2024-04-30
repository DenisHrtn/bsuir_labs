using Lab_5.Service;

class Program
{
    public static Firm Firm { get; } = new Firm();

    static void Main(string[] args)
    {
        Firm.AddTariff(new Tariff(CargoType.Heavy, 10));
        Firm.AddTariff(new Tariff(CargoType.Fragile, 15));
        Firm.AddTariff(new Tariff(CargoType.Light, 5));
        
        Client client1 = new Client("Романюк");
        Client client2 = new Client("Харитончик");
        Firm.RegisterClient(client1);
        Firm.RegisterClient(client2);
        
        Firm.AddOrderToClient(client1, 3, CargoType.Heavy);
        Firm.AddOrderToClient(client2, 4, CargoType.Fragile);
        Firm.AddOrderToClient(client1, 2, CargoType.Light);
        
        Console.WriteLine("Сумма заказов для Романюка: " + client1.CalculateOrderSum());
        Console.WriteLine("Сумма заказов для Харитончика: " + client2.CalculateOrderSum());
        
        Console.WriteLine("Общая стоимость заказов: " + Firm.CalculateTotalOrderSum());
    }
}
