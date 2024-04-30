namespace Lab_6.ComputerEquipments;

public class Laptop : ComputerEquipment
{
    public string Processor { get; set; }
    public int RAM { get; set; }
    
    public Laptop(string model, decimal price, string processor, int ram)
    {
        Model = model;
        Price = price;
        Processor = processor;
        RAM = ram;
        Console.WriteLine($"Создан новый ноутбук {model}.");
    }
    
    public void SetPassword(string password)
    {
        Console.WriteLine($"Пароль для {Model} установлен: {password}");
    }

    public void GetInfoAboutLaptop()
    {
        Console.WriteLine($"У ноутбука {Model} процессор {Processor} и {RAM} оперативной памяти");
    }
    
    public override void PowerOn()
    {
        Console.WriteLine($"Ноутбук {Model} включен и готов к использованию.");
    }
    
    public override void PowerOff()
    {
        Console.WriteLine($"Ноутубк {Model} выключен.");
    }

    public override void GetPrice()
    {
        Console.WriteLine($"Стоимость ноутбука ({Model}) - {Price}");
    }
    
    public override void Upgrade()
    {
        Console.WriteLine($"Ноутбук {Model} обновлен до новой версии.");
    }
}
