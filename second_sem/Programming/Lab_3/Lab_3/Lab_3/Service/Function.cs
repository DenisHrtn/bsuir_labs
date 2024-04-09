namespace Lab_3.Service;

public class MathFunction
{
    public double GetDoubleNumFromUser()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Error input.");
            Console.WriteLine("Input number : ");
        }
        return number;

    }
    
    public (double, double, double, double) GetValuesForFunction()
    {
        MathFunction mathFunc = new MathFunction();
        Console.WriteLine("Enter value for z");
        double z = mathFunc.GetDoubleNumFromUser();
        Console.WriteLine("Enter value for c");
        double c = mathFunc.GetDoubleNumFromUser();
        Console.WriteLine("Enter value for d");
        double d = mathFunc.GetDoubleNumFromUser();
        Console.WriteLine("Enter value for k");
        double k = mathFunc.GetDoubleNumFromUser();
    
        return (z, c, d, k);
    }

    public double ResultOfFunction(double z, double c, double d, double k)
    {
        double y = 0;

        if (z < 0)
        {
            y = Math.Pow(Math.Sin(c * Math.Pow(z, 2) - z + Math.Pow(d, 2) + k * Math.Pow(Math.Pow(z, 2) - z, 2)), 3);
            Console.WriteLine("Path z < 0");
            Console.WriteLine(y);
        }
        else if (z >= 0)
        {
            y = Math.Pow(Math.Sin(c * Math.Pow(z, 3) + Math.Pow(d, 2) + k * Math.Pow(Math.Pow(z, 3), 2)), 3);
            Console.WriteLine("Path z >= 0");
            Console.WriteLine(y);
        }
            
        return y; 
    }
}
