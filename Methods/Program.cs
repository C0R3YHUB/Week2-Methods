CreateMenu();

void CreateMenu()
{
    try
    {
        // Construct the menu
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Add Numbers");
        Console.WriteLine("4. Calculate Area");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");

        // Accept the users choice
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SayHello();
                break;
            case "2":
                AddNumbers();
                break;
            case "3":
                break;
            case "4":
                Area();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
    }


}

static void SayHello()
{
    Console.WriteLine("Hello, world!");
}

static void AddNumbers()
{
    Console.WriteLine("Please enter the first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter the second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber + secondNumber;
    Console.WriteLine($"Result: {result}");
}

static void Area()
{

    try
    {
        Console.WriteLine("Please enter rectangle length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter rectangle width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(length, width);

        Console.WriteLine($"The area of the rectangle is: {area}");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Area Calculated!");
    }


}

static double CalculateArea(double length, double width)
{
    double area = length * width;
    return area;
}