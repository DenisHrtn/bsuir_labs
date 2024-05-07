namespace Lab_8.FirmService;

public class WithoutDiscountStrategy : IPriceCalculationStrategy
{
    public double CalculatePrice(double originalPrice, double discount)
    {
        return originalPrice;
    }
}
