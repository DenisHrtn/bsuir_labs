using System;
using Lab_3.Service;
using Lab_3;


class Program
{
    static void Main(string[] args)
    {
        // NumberClass
        Number processor = new Number();
        Console.WriteLine("Enter number: ");
        int inputNum = processor.GetNumberFromUser();
        int result = processor.ChangeNum(inputNum);
        Console.WriteLine($"Result: {result}");
        
        Console.WriteLine("Function program");
        Console.WriteLine(new string('-', 40));
        
        // Function class
        MathFunction mathFunc = new MathFunction();
        (double z, double c, double d, double k) = mathFunc.GetValuesForFunction();
        double result_2 = mathFunc.ResultOfFunction(z, c, d, k);
        
        Console.WriteLine("Date program");
        Console.WriteLine(new string('-', 40));
        
        // DateService class
        DateService dateService = new DateService();
        Console.WriteLine("Enter date in format YYYY-MM-DD: ");
        string inputDate = Console.ReadLine(); 
        string dayOfWeek = dateService.GetDay(inputDate);
        Console.WriteLine($"Day of week for {inputDate}: {dayOfWeek}");
        
        int day = dateService.GetNumberFromUser("Enter day:");
        int month = dateService.GetNumberFromUser("Enter month:");
        int year = dateService.GetNumberFromUser("Enter year:");
        int differentDays = dateService.GetDaysSpan(day, month, year);
        Console.WriteLine($"Between the current date and the entered date will pass:{differentDays}");
    }
}
