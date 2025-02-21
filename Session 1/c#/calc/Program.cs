using System;

public class Calculator
{
    public static double num1, num2;

    public static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        try
        {
            num1 = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Main();
        }
        
        Console.WriteLine("Enter the operator: ");
        string? op = Console.ReadLine();

        Console.WriteLine("Enter the second number: ");
        try
        {
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Main();
        }
        if (op == "+")
        {
            Console.WriteLine(num1 + num2);
        }
        else if (op == "-")
        {
            Console.WriteLine(num1 - num2);
        }
        else if (op == "*")
        {
            Console.WriteLine(num1 * num2);
        }
        else if (op == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {
                Console.WriteLine(num1 / num2);
            }
        }
        else
        {
            Console.WriteLine("Invalid operator");
        }
        Console.WriteLine("Do you want to perform another operation? (yes/no)");
        string? choice = Console.ReadLine();
        if (choice.ToLower() == "yes")
        {
            Main();
        }
        else{
            Console.WriteLine("Goodbye!");
            return;
        }
    }
}