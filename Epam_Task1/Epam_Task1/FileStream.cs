using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Epam_Task1
{
    internal class FileStream
    {
        public int[] Read()
        {
            using (StreamReader stream = new StreamReader("input.txt"))
            {
                string line = stream.ReadLine();
                if (!(int.TryParse(line, out var tempX)))
                {
                    throw new FormatException("Enter correct value");
                }
                var n = tempX;
                int[] arr = new int[n];

                for(var i = 0; i < n; i++)
                {
                    if (!(int.TryParse(stream.ReadLine(), out var tempk)))
                    {
                        throw new FormatException("Enter correct value");
                    }
                    arr[i] = tempk;
                }

                return arr;
            }
        }
    }
}
