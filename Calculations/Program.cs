using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            Calculator(text, firstNum, secondNum);

        }

        static void Calculator(string texting, double first, double second)
        {
            double result = 0;
            if (texting == "add")
            {
                result = first + second;
            }
            if (texting == "divide")
            {
                result = first / second;
            }
            if (texting == "multiply")
            {
                result = first * second;
            }
            if (texting == "subtract")
            {
                result = first - second;
            }
            Console.WriteLine(result);
        }
    }
}
