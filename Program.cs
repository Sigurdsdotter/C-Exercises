using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            Console.WriteLine("Enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose the operation: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

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
                case 4:
                    try
                    {
                        if (number2 == 0)
                        {
                            throw new DivideByZeroException("Sorry, I can't divide by 0");
                        }
                        Console.WriteLine(number1 / number2);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Write 1, 2, 3, or 4 please");
                    break;
            }
*/
          
            string ifFound = "The substring exists in the string.";

            Console.WriteLine("Check wether a given substring is present in the given string:");
            
            string originalTxt = "Rock'n roll is good for your soul";
            Console.WriteLine(originalTxt);

            Console.WriteLine("Input the substring to search: ");
            string testTxt = Console.ReadLine();
            
                int index = originalTxt.IndexOf(testTxt);

                    if (index >= 0)
                    {
                        Console.WriteLine(ifFound);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you need rock'n roll");
                    }


        }
    }
}

