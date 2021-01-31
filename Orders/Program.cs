using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            Orders(product,price);

        }

        static void Orders(string product, double price)
        {
            if (product == "coffee")
            {
                price = price * 1.50;
            }
            else if (product == "water")
            {
                price = price * 1.00;
            }
            else if (product == "coke")
            {
                price = price * 1.40;
            }
            else if (product == "snacks")
            {
                price = price * 2.00;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
