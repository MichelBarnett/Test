using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Sample");
            Console.WriteLine();

            int param1 = 4;
            int param2 = 8;
            int sum = MathHelper.Add(param1, param2);
            Console.WriteLine($"{param1} + {param2} = {sum}");
            Console.WriteLine();

            int factor1 = 6;
            int factor2 = 7;
            int product = MathHelper.Multiply(factor1, factor2);
            Console.WriteLine($"{factor1} * {factor2} = {product}");
            Console.WriteLine();

            float dividend = 12;
            float divisor = 3;
            float quotient = MathHelper.Divide(dividend, divisor);
            Console.WriteLine($"{dividend} / {divisor} = {quotient}");
            Console.WriteLine();

            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
        }
    }
}