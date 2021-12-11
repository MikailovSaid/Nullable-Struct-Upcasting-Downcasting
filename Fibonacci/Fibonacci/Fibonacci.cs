using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        public void FibMethod(int number)
        {
            int firstnum = 0;
            int secondnum = 1;
            int thirdnum;
            for (int i = 2; i < number; ++i)
            {
                thirdnum = firstnum + secondnum;
                Console.WriteLine(thirdnum + " ");
                firstnum = secondnum;
                secondnum = thirdnum;
            }
        }
    }
}
