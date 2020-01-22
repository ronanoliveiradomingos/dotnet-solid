using System;
namespace Scripts
{
    public abstract class Calculator
    {
        protected readonly int[] _numbers;

        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();
    }

    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Sum();
    }

    public class SubCalculator : Calculator
    {
        public SubCalculator(int[] numbers) : base(numbers)
        {
        }

        public override Calculate() => _numbers.Sub();
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new int[] { 2, 2 };

            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            Console.WriteLine();

            Calculator sub = SubCalculator(numbers);
            Console.WriteLine($"The sub of all the numbers: {sub.Calculate()}");

        }
    }
}