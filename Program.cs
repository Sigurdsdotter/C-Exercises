using Microsoft.VisualBasic;

namespace calculator;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose the operation: ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtractio");
        Console.WriteLine("3. Multiplication");

        int choice = int.Parse(Console.ReadLine());


        switch (choice)
        {
            case 1:
                Console.WriteLine(number1 + number2);
                break;
            case 2:
                Console.WriteLine(number1 - number2);
                break;
            case 3:
                Console.WriteLine(number1 * number2);
                break;
            default:
                Console.WriteLine("Write 1, 2 or 3 please");
                break;
        }


    }
}

