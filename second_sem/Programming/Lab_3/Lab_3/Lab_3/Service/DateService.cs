namespace Lab_3.Service;

public class DateService
{
    public int GetNumberFromUser(string message)
    {
        Console.WriteLine(message);
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Error input");
            Console.WriteLine("Input number: ");
        }
        return number;
    }
    
    public string GetDay(string date)
    {
        if (DateTime.TryParse(date, out DateTime parsedDate))
        {
            return parsedDate.ToString("dddd");
        }
        else
        {
            return "Invalid date format";
        }
    }

    public int GetDaysSpan(int day, int month, int year)
    {
        if (!DateTime.IsLeapYear(year) && month == 2 && day == 29)
        {
            Console.WriteLine("Invalid date format");
            return -1; 
        }

        if (day > DateTime.DaysInMonth(year, month) || day < 1 || month < 1 || month > 12)
        {
            Console.WriteLine("Invalid date format");
            return -1; 
        }

        DateTime specifiedDate = new DateTime(year, month, day);
        DateTime currentDate = DateTime.Today;
        TimeSpan span = specifiedDate - currentDate;

        return span.Days;
    }

}
