using System;

namespace GetReady
{
    class Program
    {
        static double Calculate(double operand1, double operand2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand1 / operand2;
                default:
                    Console.WriteLine("Valid operators +, -, * or /");
                    return Calculate(operand1, operand2, operation);
            }
        }
        static void Main(string[] args)
        {
            Double operand1, operand2;
            Char operation;

            do
            {
                Console.Clear();
                Console.WriteLine("\tSimple calculator");

                Console.Write("Enter the operand 1: ");
                operand1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operand 2: ");
                operand2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operation: ");
                operation = Convert.ToChar(Console.Read());

                Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + Calculate(operand1, operand2, operation));
                Console.WriteLine("\tPress any key to do another calculation or " +
                    "\n\t\tctrl + c to exit");
                Console.ReadKey();
                Console.ReadLine();
            }
            while (true);
        }
    }
}