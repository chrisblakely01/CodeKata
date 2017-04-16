using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoute
{
    public class Number
    {
        public int DigitalRoot(long n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += (int)n % 10;
                n /= 10;
            }
            if (sum >= 10)
            {
                return DigitalRoot(sum);
            }
            return (int)sum;
        }
    }
}
