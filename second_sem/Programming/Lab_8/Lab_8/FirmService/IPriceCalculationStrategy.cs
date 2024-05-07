namespace Lab_8.FirmService;

public interface IPriceCalculationStrategy
{
    double CalculatePrice(double originalPrice, double discount);
}
