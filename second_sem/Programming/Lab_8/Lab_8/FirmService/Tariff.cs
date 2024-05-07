namespace Lab_8.FirmService;

public class Tariff
{
    public string Name { get; set; }
    public double Price { get; set; }
    public double Discount { get; set; }
    private IPriceCalculationStrategy _calculationStrategy;

    public Tariff(string name, double price, double discount)
    {
        Name = name;
        Price = price;
        Discount = discount;
    }

    public void SetCalculationStrategy(IPriceCalculationStrategy strategy)
    {
        _calculationStrategy = strategy;
    }

    public double CalculatePrice()
    {
        if (_calculationStrategy != null)
        {
            return _calculationStrategy.CalculatePrice(Price, Discount);
        }
        else
        {
            throw new InvalidOperationException("Calculation strategy not set.");
        }
    }
}
