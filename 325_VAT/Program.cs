using System;

namespace _325_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ").Select(double.Parse);
            var numberWithVAT = numbers.Select(x => x * 1.20);

            var numberWithVAT2 = Console.ReadLine().Split(", ").Select(x => double.Parse(x) * 1.20);
            var numberWithVAT3 = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x * 1.20);

            foreach (var number in numberWithVAT)
            {
                Console.WriteLine(number);
            }

            foreach (var number in numberWithVAT2)
            {
                Console.WriteLine(number);
            }

            foreach (var number in numberWithVAT3)
            {
                Console.WriteLine(number);
            }
        }
    }
}