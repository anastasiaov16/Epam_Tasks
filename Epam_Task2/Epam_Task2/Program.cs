using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FileStream file = new FileStream();
            BinarySearch bS = new BinarySearch();

            var arr = file.Read();
            Console.Write("Enter the searched number: ");
            int value = int.Parse(Console.ReadLine());

            var res = bS.bSearch(arr, value);
            bS.Result(res);
        }
    }
}
