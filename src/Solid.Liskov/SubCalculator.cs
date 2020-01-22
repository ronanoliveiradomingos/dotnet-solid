using System;
using System.Linq;
using Solid.Liskov;

namespace Solid.Liskov
{
    public class SubCalculator : Calculator
    {
        public SubCalculator(int[] numbers) : base(numbers)
        {
        }
        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
