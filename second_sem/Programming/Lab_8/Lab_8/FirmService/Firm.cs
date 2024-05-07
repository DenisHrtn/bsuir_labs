namespace Lab_8.FirmService;

public class Firm
{
    private List<Tariff> _tariffs = new List<Tariff>();
    
    // метод для добавления тарифа
    public void AddTariff(Tariff tariff)
    {
        _tariffs.Add(tariff);
    }
    
    // поиск тарифа с минимальной стоимостью
    public Tariff FindMinPriceTariff()
    {
        if (_tariffs.Count == 0)
            return null;

        Tariff minPriceTariff = _tariffs[0];
        foreach (Tariff tariff in _tariffs)
        {
            if (tariff.Price < minPriceTariff.Price)
                minPriceTariff = tariff;
        }

        return minPriceTariff;
    }
}
