using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // HomeWork C# Basic 10.03.2021 Task 1
            /////////////////////////////////////////////////////////////////////////////////////////////

            // tuka go zemam prviot broj od user-ot
            Console.WriteLine("Enter first number!");
            bool ifFirstNumberOk = int.TryParse(Console.ReadLine(), out int firstNumber);
            //tuka go zemam vtoriot broj od user-ot
            Console.WriteLine("Enter second number!");
            bool ifSecondNumberOk = int.TryParse(Console.ReadLine(), out int secondNumber);
            // tuka mu kazuvam da izbere operator
            Console.WriteLine("choose one of these operations: + - * /");
            string operation = Console.ReadLine();
            Console.WriteLine(operation);

            // tuka so switch funkcijata izvrshuvam kod spored izborot na operatorot od user-ot
            switch (operation)
            {
                case "+":
                    Console.WriteLine("The result is: " + (firstNumber + secondNumber));
                    break;
                case "-":
                    Console.WriteLine("The result is: " + (firstNumber - secondNumber));
                    break;
                case "*":
                    Console.WriteLine("The result is: " + firstNumber * secondNumber);
                    break;
                case "/":
                    Console.WriteLine("The result is: " + firstNumber / secondNumber);
                    break;
                default:
                    Console.WriteLine("you chose wrong operator");
                    break;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////
            Console.ReadLine();
        }
    }
}
