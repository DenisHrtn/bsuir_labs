namespace Lab_6.ComputerEquipments;

public class Printer : ComputerEquipment
{
    public string PrintType { get; set; }
    public bool PaperState { get; set; }
    
    public Printer(string model, decimal price, string printType, bool paperState)
    {
        Model = model;
        Price = price;
        PrintType = printType;
        PaperState = paperState;
        Console.WriteLine($"Создан новый принтер {model}.");
    }
    
    public override void PowerOn()
    {
        PowerOn("офис");
    }
    
    public void PowerOn(string location)
    {
        Console.WriteLine($"Принтер {Model} включен в помещении {location}.");
    }
    
    public override void PowerOff()
    {
        Console.WriteLine($"{Model} выключен.");
    }

    public override void GetPrice()
    {
        Console.WriteLine($"Стоимость принтера {Model} - {Price}");
    }
    
    public void PrintDocument(string document)
    {
        if (PaperState)
        {
            Console.WriteLine($"Документ {document} успешно напечатан на принтере {Model}");
        }
        else
        {
            Console.WriteLine($"Ошибка: Нет бумаги на принтере {Model}.");
        }
    }

    public void GetStateAndInfo()
    {
        Console.WriteLine($"У принтера {Model} состояние бумаги - {PaperState} и тип его печати {PrintType}");
    }
    
    public void ReplaceCartridge()
    {
        Console.WriteLine($"Картридж на принтере {Model} заменен.");
    }
}
