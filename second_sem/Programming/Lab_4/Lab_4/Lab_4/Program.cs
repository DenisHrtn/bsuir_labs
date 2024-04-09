using Lab_4.SingletonClasses;

class Program
{
    static void Main(string[] args)
    {
        // создание экземпляра класса Tariff (единственный экземпляр)
        Tariff tariff = Tariff.GetInstance(100);

        // создание экземпляра класса TransportCompany (единственный экземпляр)
        TransportCompany company = TransportCompany.GetInstance("My Company", tariff);

        double[] cargo = { 10, 35, 40 };
        double totalEarning = company.ComputeTotalEarnings(cargo);

        company.ChangeCompanyTariff(155);

        totalEarning = company.ComputeTotalEarnings(cargo);
        Console.WriteLine($"Total revenue with new tariff: {totalEarning}");
    }
}