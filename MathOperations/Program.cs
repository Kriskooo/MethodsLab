using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            double firstNum = double.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            Calculator(firstNum, text, secondNum);

        }

        static void Calculator(double first, string texting, double second)
        {
            double result = 0;
            if (texting == "+")
            {
                result = first + second;
            }
            if (texting == "/")
            {
                result = first / second;
            }
            if (texting == "*")
            {
                result = first * second;
            }
            if (texting == "-")
            {
                result = first - second;
            }

            Console.WriteLine(result);
        }
    }
}
