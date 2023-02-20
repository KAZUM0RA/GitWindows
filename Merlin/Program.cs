using System;

namespace Calculator
{
   class Program
   {
       static void Main(string[] args)
       {
           // Print a message to the screen
           Console.WriteLine("Welcome to the Calculator!");

           // Read user input
           Console.Write("Please enter the first number: ");
           int num1 = Convert.ToInt32(Console.ReadLine());
           Console.Write("Please enter the second number: ");
           int num2 = Convert.ToInt32(Console.ReadLine());

           // Perform calculations
           int sum = num1 + num2;
           int difference = num1 - num2;
           int product = num1 * num2;
           double quotient = (double) num1 / num2;

           // Display the results
           Console.WriteLine();
           Console.WriteLine($"The sum of {num1} + {num2} = {sum}.");
           Console.WriteLine($"The difference of {num1} - {num2} = {difference}.");
           Console.WriteLine($"The product of {num1} * {num2} = {product}.");
           Console.WriteLine($"The quotient of {num1} / {num2} = {quotient}.");
       }
   }
}

