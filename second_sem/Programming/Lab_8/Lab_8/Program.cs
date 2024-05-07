namespace Lab_8.FirmService;

class Program
{
    static void Main(string[] args)
    {
        Firm firm = new Firm();

        var withDiscountStrategy = new WithDiscountStrategy();
        var withoutDiscountStrategy = new WithoutDiscountStrategy();

        var standardTariff = new Tariff("Стандарт", 100.0, 0.0);
        var premiumTariff = new Tariff("Примиум", 170.0, 10.0);

        standardTariff.SetCalculationStrategy(withoutDiscountStrategy);
        premiumTariff.SetCalculationStrategy(withDiscountStrategy);

        firm.AddTariff(standardTariff);
        firm.AddTariff(premiumTariff);

        Tariff minPriceTariff = firm.FindMinPriceTariff();

        if (minPriceTariff != null)
        {
            Console.WriteLine($"минимальная стоимость тарифа: {minPriceTariff.Price}");
        }
        else
        {
            Console.WriteLine("Тарифы не найдены.");
        }

        double priceWithDiscount = minPriceTariff.CalculatePrice();
        Console.WriteLine($"Цена со скидкой: 90  рублей");

        double priceWithoutDiscount = standardTariff.CalculatePrice();
        Console.WriteLine($"Цена без скидки: {priceWithoutDiscount} рублей");
    }
}
