using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // HomeWork C# Basic 10.03.2021 Task 2
            ///////////////////////////////////////////////////////////////////////////////////

            // tuka go zemam prviot broj od user-ot
            Console.WriteLine("Enter first number!");
            bool ifFirstNumberOk = int.TryParse(Console.ReadLine(), out int firstNumber);
            // tuka go zemam vtoriot broj od user-ot
            Console.WriteLine("Enter second number!");
            bool ifSecondNumberOk = int.TryParse(Console.ReadLine(), out int secondNumber);
            // tuka go zemam tretiot broj od user-ot
            Console.WriteLine("Enter third number!");
            bool ifThirdNumberOk = int.TryParse(Console.ReadLine(), out int thirdNumber);
            // tuka go zemam chetvrtiot broj od user-ot
            Console.WriteLine("Enter fourth number!");
            bool ifFourthNumberOk = int.TryParse(Console.ReadLine(), out int fourthNumber);

            int averageOfAllNumbers = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            Console.WriteLine("The average of " + (firstNumber, secondNumber, thirdNumber, fourthNumber) + " is: " + averageOfAllNumbers);

            ///////////////////////////////////////////////////////////////////////////////////
            Console.ReadLine();
        }
    }
}
