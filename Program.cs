using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = "3 cups of coffee";
            var name = "Lindsay Ledford";
            var date = "8/11/20";
            Console.WriteLine("Today, " + date + " " + name + " drank " + numberOfCupsOfCoffee);

            Console.Write("Good Afternoon! What is your name? ");
            var userName = Console.ReadLine();
            Console.WriteLine($"Awesome to meet you, {userName}");

            Console.WriteLine("What is your first favorite number? ");
            var firstNumberAsString = Console.ReadLine();
            Console.WriteLine("What's is your second favorite number? ");
            var secondNumberAsString = Console.ReadLine();
            Console.WriteLine($"{firstNumberAsString} {secondNumberAsString} " + "Nice!");
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);
            var sum = firstOperand + secondOperand;
            Console.WriteLine("Let's do some math. What if you add both together?");
            Console.WriteLine(sum);
            var difference = firstOperand - secondOperand;
            Console.WriteLine("If you were to subtract both...");
            Console.WriteLine(difference);
            var product = firstOperand * secondOperand;
            Console.WriteLine("What if you wanted to multiply both?");
            Console.WriteLine(product);
            var quotient = firstOperand / secondOperand;
            Console.WriteLine(quotient);
            Console.WriteLine("Obviously if we divided the first number from the second!");
            var remainder = secondOperand % firstOperand;
            Console.WriteLine("What if you wanted to divide the second number from the first instead? You'd get..");
            Console.WriteLine(remainder);























        }
    }
}
