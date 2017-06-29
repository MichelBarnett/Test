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

            param1 = 15;
            param2 = 4;
            int difference = MathHelper.Subtract(param1, param2);
            Console.WriteLine($"{param1} - {param2} = {difference}");
            Console.WriteLine();

            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
        }
    }
}