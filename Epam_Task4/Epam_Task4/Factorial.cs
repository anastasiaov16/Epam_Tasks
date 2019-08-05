using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task4
{
    internal class Factorial
    {
        public int Fact(int i)
        {
            if (i == 1)
            {
                Console.Write(i + " = ");
                return 1;
            }
            else
            Console.Write(i + " * ");
            return i * Fact(i - 1);

        }
    }
}
