using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task2
{
    internal class BinarySearch
    {
        public int bSearch(int[] array, int sValue, int firstIndex = 0, int lastIndex = -1)
        {
            if(lastIndex == -1)
            {
                lastIndex = array.Length;
            }
            var middle = (firstIndex + lastIndex) / 2;
            var middleValue = array[middle];

            if (firstIndex > lastIndex)
            {
                return -1;
            }

            if (middleValue == sValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > sValue)
                {
                    return bSearch(array, sValue, firstIndex, middle - 1);
                }
                else
                {
                    return bSearch(array, sValue, middle + 1, lastIndex);
                }
            }
        }

        public void Result(int res)
        {
            if (res < 0)
            {
                Console.WriteLine("Такого элемента нет!");
            }
            else
            {
                Console.WriteLine("Такой элемент найден! Его индекс = {0}", res);
            }
        }
    }
}
