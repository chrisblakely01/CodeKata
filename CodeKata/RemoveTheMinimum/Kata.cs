using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheMinimum
{
    public class Kata
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            int smallest = Int32.MaxValue;

            foreach(var value in numbers)
            {
                if (value < smallest)
                    smallest = value;
            }

            numbers.Remove(smallest);

            return numbers;
        }

        public static List<int> RemoveSmallestLinq(List<int> numbers)
        {
            numbers.Remove(numbers.DefaultIfEmpty().Min());
            return numbers;
        }
    }
}
