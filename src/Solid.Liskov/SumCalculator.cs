using System;
using System.Linq;
using Solid.Liskov;

namespace Solid.Liskov
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        {
        }
        public override int Calculate() => _numbers.Sum();
    }
}
