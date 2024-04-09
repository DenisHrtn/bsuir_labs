namespace Lab_4.SingletonClasses;

public class Tariff
{
    private double priceOneTon;

    // приватный статический экземпляр класса Tariff
    private static Tariff _instance;

    // приватный конструктор для создания экземпляра класса Tariff
    private Tariff(double priceOneTon)
    {
        this.priceOneTon = priceOneTon;
    }

    // публичный статический метод для получения единственного экземпляра класса Tariff
    public static Tariff GetInstance(double priceOneTon)
    {
        if (_instance == null)
        {
            _instance = new Tariff(priceOneTon);
        }
        return _instance;
    }

    // метод для расчета дохода для заданного веса груза
    public double CalculateEarnings(double cargo)
    {
        return cargo * priceOneTon;
    }

    // метод для изменения тарифа
    public void ChangeTariff(double newPrice)
    {
        this.priceOneTon = newPrice;
    }
}
