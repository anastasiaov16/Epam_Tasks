using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task1
{
    internal class Program
    {
        private static void Show(int [] arr)
        {
            Console.WriteLine("Sorted:");
            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();
        }
        private static void Main(string[] args)
        {
            FileStream file = new FileStream();
            QuickSort qs = new QuickSort();

            var array = file.Read();

            qs.QSort(array, 0, array.Length-1);

            Show(array);
        }
    }
}
