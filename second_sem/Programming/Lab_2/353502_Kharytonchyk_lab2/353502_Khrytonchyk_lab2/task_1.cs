int option;
do
{   
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Next step");
    Console.WriteLine("2. Stop program");
    Console.WriteLine("Choice your option:1 or 2");
    option = GetNumberFromUser();

    switch (option)
    {
        case 1:
            int a, b, c;
            Console.WriteLine("Enter value of sides:");
            a = GetNumberFromUser();
            b = GetNumberFromUser();
            c = GetNumberFromUser();
            if (a + b > c && a + c > b && c + b > a)
            {
                if ((a * a + b * b == c * c) | (a * a + c * c == b * b) | (b * b + c * c == a * a))
                {
                    Console.WriteLine("Triangle is rectangular");
                }
                else
                {
                    Console.WriteLine("Triangle is not rectangular");
                }
                break;
            }
            else
            {
                Console.WriteLine("It's not a triangle");
            }
            break;
        case 2:
            Console.WriteLine("The program is completed");
            break;
        default:
            Console.WriteLine("Wrong choice, try again");
            break;
    }
} while (option != 2);
static int GetNumberFromUser()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error input.");
        Console.WriteLine("Input number : ");
    }
    return number;

}