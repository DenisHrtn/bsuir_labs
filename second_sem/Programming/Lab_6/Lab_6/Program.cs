using Lab_6.ComputerEquipments;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop = new Laptop("MacBook Air M1 2020", 3100, "M1", 8);
        
        laptop.PowerOn();
        laptop.GetPrice();
        laptop.GetInfoAboutLaptop();
        laptop.SetPassword("qwerty");
        laptop.Upgrade();
        laptop.PowerOff();
        Console.WriteLine("-----------------------");
        
        Printer printer = new Printer( "HP LaserJet Pro MFP M28w",  300,  "лазерный", true);
        
        printer.PowerOn();
        printer.GetPrice();
        printer.GetStateAndInfo();
        printer.PrintDocument("Отчет");
        printer.ReplaceCartridge();
        printer.PowerOff();
        Console.WriteLine("-----------------------");
        
        ComputerPeripheral computerPeripheral = new ComputerPeripheral("Keychron V3", 350);
        
        computerPeripheral.PowerOn();
        computerPeripheral.GetPrice();
        computerPeripheral.Connect();
        computerPeripheral.PowerOff();
    }
}