namespace Lab_8.FirmService;

public class WithDiscountStrategy : IPriceCalculationStrategy
{
    public double CalculatePrice(double originalPrice, double discount)
    {
        return originalPrice * (1 - discount / 100);
    }
}
