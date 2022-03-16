using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // HomeWork C# Basic 10.03.2021 Task 3
            //////////////////////////////////////////////////////////////////////////////////

            // tuka go zemam prviot broj od user-ot
            Console.WriteLine("Enter first number!");
            bool ifFirstNumberOk = int.TryParse(Console.ReadLine(), out int firstNumber);

            // tuka go zemam vtoriot broj od user-ot
            Console.WriteLine("Enter second number!");
            bool ifSecondNumberOk = int.TryParse(Console.ReadLine(), out int secondNumber);



            Console.WriteLine("***before swing result***");
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("***after swing result***");
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
           
            //////////////////////////////////////////////////////////////////////////////////
            Console.ReadLine();
        }
    }
}
