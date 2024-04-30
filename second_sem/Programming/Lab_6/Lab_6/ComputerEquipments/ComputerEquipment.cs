namespace Lab_6.ComputerEquipments;

public abstract class ComputerEquipment
{
    public string Model { get; set; }
    public decimal Price { get; set; }
    
    public abstract void PowerOn();
    
    public abstract void PowerOff();
    
    public abstract void GetPrice();
    
    public virtual void Upgrade()
    {
        Console.WriteLine($"Оборудование {Model} обновлено.");
    }
}
