using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task4
{
    internal class Program
    {
        private static void Main()
        {
            FileStream wwl = new FileStream();
            Factorial fact = new Factorial();
            Console.WriteLine(fact.Fact(wwl.Read())); 
        }
    }
}
