using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task1
{
    internal class QuickSort
    {
       public void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        public int SearchMiddleIndex(int[] array, int firstIndex, int lastIndex)
        {
            var middleIndex = firstIndex - 1;
            for (var i = firstIndex; i < lastIndex; i++)
            {
                if (array[i] < array[lastIndex])
                {
                    middleIndex++;
                    Swap(ref array[middleIndex], ref array[i]);
                }
            }

            middleIndex++;
            Swap(ref array[middleIndex], ref array[lastIndex]);
            return middleIndex;
        }

        public int[] QSort(int[] array, int firstIndex, int lastIndex)
        {
            if (firstIndex >= lastIndex)
            {
                return array;
            }

            var middleIndexIndex = SearchMiddleIndex(array, firstIndex, lastIndex);
            QSort(array, firstIndex, middleIndexIndex - 1);
            QSort(array, middleIndexIndex + 1, lastIndex);

            return array;
        }
    }
}
