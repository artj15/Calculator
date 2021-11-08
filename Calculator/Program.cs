using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите оператор: /, *, -, +.");
            string c = Console.ReadLine();
            if (c == char.ToString('/') & b != 0)
            {
                Console.WriteLine(a / b);
            }
            else if (c == char.ToString('*'))
            {
                Console.WriteLine(a * b);
            }
            else if (c == char.ToString('-'))
            {
                Console.WriteLine(a - b);
            }
            else if (c == char.ToString('+'))
            {
                Console.WriteLine(a + b);
            };
            Console.ReadKey();
        }
    }
}
