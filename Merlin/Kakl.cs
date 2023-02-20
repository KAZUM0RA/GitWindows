/*using System;

namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");
            int num1 = 0;
            int num2 = 0;
            string input;
            Console.WriteLine("Введите первое число:");
            input = Console.ReadLine();
            num1 = int.Parse(input);
            Console.WriteLine("Введите второе число:");
            input = Console.ReadLine();
            num2 = int.Parse(input);

            Console.WriteLine("Выберите операцию (+, -, *, /):");
            input = Console.ReadLine();

            if (input == "+")
            {
                Console.WriteLine($"Result: {num1 + num2}");
            }
            else if (input == "-")
            {
                Console.WriteLine($"Result: {num1 - num2}");
            }
            else if (input == "*")
            {
                Console.WriteLine($"Result: {num1 * num2}");
            }
            else if (input == "/")
            {
                Console.WriteLine($"Result: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Недопустимая операция!");
            }
            Console.ReadLine();
        }
    }
}*/