using System;
using System.Linq;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string texting = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            RepeatString(texting, count);
            string result = RepeatString(texting, count);
            Console.Write(result);
        }
        static string RepeatString(string text, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}
