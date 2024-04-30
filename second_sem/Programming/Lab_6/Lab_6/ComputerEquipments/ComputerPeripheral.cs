namespace Lab_6.ComputerEquipments;

public sealed class ComputerPeripheral : ComputerEquipment
{
    public string Model { get; set; }
    public decimal Price { get; set; }
    
    public ComputerPeripheral(string model, decimal price)
    {
        Model = model;
        Price = price;
        Console.WriteLine($"Создано новое периферийное компьютерное устройство {model}.");
    }

    public override void PowerOn()
    {
        Console.WriteLine($"{Model} включен");
    }

    public override void PowerOff()
    {
        Console.WriteLine($"{Model} выключен.");
    }

    public override void GetPrice()
    {
        Console.WriteLine($"Стоимость {Model} - {Price}");
    }
    
    public void Connect()
    {
        Console.WriteLine($"{Model} подключен.");
    }
}