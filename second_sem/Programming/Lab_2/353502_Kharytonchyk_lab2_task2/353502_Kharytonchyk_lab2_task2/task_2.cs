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
            Console.WriteLine("Enter value of y: ");
            double y = GetDoubleNumFromUser();
            Console.WriteLine("Enter value of x: ");
            double x = GetDoubleNumFromUser();

            if ((y <= 23) && (y == -x) && (x >= 0))
            {
                if ((y == 23) || (y == -x) || (x == 0))
                {
                    Console.WriteLine("On border");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            break;
        case 2:
            Console.WriteLine("The program is completed");
            break;
        default:
            Console.WriteLine("Wrong choice, try again");
            break;
    }
} while(option != 2);
static double GetDoubleNumFromUser()
{
    double number;
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error input.");
        Console.WriteLine("Input number : ");
    }
    return number;

}
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