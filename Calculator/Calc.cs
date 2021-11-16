using System;

namespace Calculator
{
    public class Calc
    {

        public int num1 = 0; public int num2 = 0;

        public static void Main(string[] args)
        {
            var mc = new Calc();

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            mc.num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            mc.num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {mc.num1} + {mc.num2} = " + (mc.Summ(mc.num1, mc.num2)));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {mc.num1} - {mc.num2} = " + (mc.Sub(mc.num1, mc.num2)));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {mc.num1} * {mc.num2} = " + (mc.Mult(mc.num1, mc.num2)));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {mc.num1} / {mc.num2} = " + (mc.Div(mc.num1, mc.num2)));
                    break;
            }
            // Wait for the user to respond before closing.
            //Console.Write("Press any key to close the Calculator console app...");
            //Console.ReadKey();
        }
        public int Summ(int num1, int num2)
        {
            var add = num1 + num2;
            return add;
        }

        public int Sub(int num1, int num2)
        {
            var sub = num1 - num2;
            return sub;
        }
        public int Mult(int num1, int num2)
        {
            var mul = num1 * num2;
            return mul;
        }
        public int Div(int num1, int num2)
        {
            var div = num1 / num2;
            return div;
        }
    }
}