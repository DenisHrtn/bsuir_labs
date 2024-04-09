namespace Lab_4.SingletonClasses;

public class TransportCompany
{
    private string companyName;
    private Tariff tariff;

    // приватное статическое поле для хранения единственного экземпляра класса TransportCompany
    private static TransportCompany _instance;

    // приватный конструктор для создания экземпляра класса TransportCompany
    private TransportCompany(string companyName, Tariff tariff)
    {
        this.companyName = companyName;
        this.tariff = tariff;
    }

    // публичный статический метод для получения единственного экземпляра класса TransportCompany
    public static TransportCompany GetInstance(string companyName, Tariff tariff)
    {
        if (_instance == null)
        {
            _instance = new TransportCompany(companyName, tariff);
        }
        return _instance;
    }

    // метод для расчета общего дохода компании для заданных масс груза
    public double ComputeTotalEarnings(double[] cargo)
    {
        double totalEarning = 0;
        foreach (double weight in cargo)
        {
            totalEarning += tariff.CalculateEarnings(weight);
        }
        return totalEarning;
    }

    // метод для изменения тарифа компании
    public void ChangeCompanyTariff(double newPrice)
    {
        tariff.ChangeTariff(newPrice);
    }
}