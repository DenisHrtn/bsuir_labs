namespace Lab_3;

public class Number
{
    public int ChangeNum(int num)
    {
        if (num % 2 == 0)
        {
            return num / 2;
        } 
        else
        {
            return 0;
        }
    }
    
    public int GetNumberFromUser()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Error input");
            Console.WriteLine("Input number: ");
        }
        return number;
    }
}
