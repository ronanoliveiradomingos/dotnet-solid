using System;

namespace Solid.Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            Console.WriteLine();

            Calculator sub = new SubCalculator(numbers);
            Console.WriteLine($"The sub of all the numbers: {sub.Calculate()}");
        }
    }
}
