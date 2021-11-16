using System;
using System.IO;
using Xunit;

namespace Calculator.Tests
{
    public class CalcTest
    {
        [Fact]
        public void ShowBeAbleToCreateCalc()
        {
            Calc calc = new Calc();
            calc.num1 = 2;
            calc.num2 = 3;
            Assert.Equal(5, calc.Summ(calc.num1, calc.num2));
            Assert.Equal(-1, calc.Sub(calc.num1, calc.num2));
            Assert.Equal(6, calc.Mult(calc.num1, calc.num2));
            Assert.Equal(2 / 3, calc.Div(calc.num1, calc.num2));
            Assert.NotNull(calc);
        }

        [Fact]
        public void ShowBeAbleToSum()
        {
            var stingWriter = new StringWriter();
            Console.SetOut(stingWriter);
            var userIn = new StringReader("12" + Environment.NewLine + '3' + Environment.NewLine + 'a' + Environment.NewLine + 'b');
            Console.SetIn(userIn);
            Calc.Main(new string[] { });
            var expectedOutput = "Console Calculator in C#\r\n" +
                                 "------------------------\n\n" +
                                 "Type a number, and then press Enter\r\n" +
                                 "Type another number, and then press Enter\r\n" +
                                 "Choose an option from the following list:\r\n\t" +
                                 "a - Add\r\n\t" +
                                 "s - Subtract\r\n\t" +
                                 "m - Multiply\r\n\t" +
                                 "d - Divide\r\n" +
                                 "Your option? Your result: 12 + 3 = 15\r\n";
            Assert.Equal(expectedOutput, stingWriter.ToString());
        }

        [Fact]
        public void ShowBeAbleToSub()
        {
            var stingWriter = new StringWriter();
            Console.SetOut(stingWriter);
            var userIn = new StringReader("12" + Environment.NewLine + '3' + Environment.NewLine + 's' + Environment.NewLine + 'b');
            Console.SetIn(userIn);
            Calc.Main(new string[] { });
            var expectedOutput = "Console Calculator in C#\r\n" +
                                 "------------------------\n\n" +
                                 "Type a number, and then press Enter\r\n" +
                                 "Type another number, and then press Enter\r\n" +
                                 "Choose an option from the following list:\r\n\t" +
                                 "a - Add\r\n\t" +
                                 "s - Subtract\r\n\t" +
                                 "m - Multiply\r\n\t" +
                                 "d - Divide\r\n" +
                                 "Your option? Your result: 12 - 3 = 9\r\n";
            Assert.Equal(expectedOutput, stingWriter.ToString());
        }
        [Fact]
        public void ShowBeAbleToMult()
        {
            var stingWriter = new StringWriter();
            Console.SetOut(stingWriter);
            var userIn = new StringReader("12" + Environment.NewLine + '3' + Environment.NewLine + 'm' + Environment.NewLine + 'b');
            Console.SetIn(userIn);
            Calc.Main(new string[] { });
            var expectedOutput = "Console Calculator in C#\r\n" +
                                 "------------------------\n\n" +
                                 "Type a number, and then press Enter\r\n" +
                                 "Type another number, and then press Enter\r\n" +
                                 "Choose an option from the following list:\r\n\t" +
                                 "a - Add\r\n\t" +
                                 "s - Subtract\r\n\t" +
                                 "m - Multiply\r\n\t" +
                                 "d - Divide\r\n" +
                                 "Your option? Your result: 12 * 3 = 36\r\n";
            Assert.Equal(expectedOutput, stingWriter.ToString());
        }
        [Fact]
        public void ShowBeAbleToDiv()
        {
            var stingWriter = new StringWriter();
            Console.SetOut(stingWriter);
            var userIn = new StringReader("12" + Environment.NewLine + '3' + Environment.NewLine + 'd' + Environment.NewLine + 'b');
            Console.SetIn(userIn);
            Calc.Main(new string[] { });
            var expectedOutput = "Console Calculator in C#\r\n" +
                                 "------------------------\n\n" +
                                 "Type a number, and then press Enter\r\n" +
                                 "Type another number, and then press Enter\r\n" +
                                 "Choose an option from the following list:\r\n\t" +
                                 "a - Add\r\n\t" +
                                 "s - Subtract\r\n\t" +
                                 "m - Multiply\r\n\t" +
                                 "d - Divide\r\n" +
                                 "Your option? Your result: 12 / 3 = 4\r\n";
            Assert.Equal(expectedOutput, stingWriter.ToString());
        }
    }
}
