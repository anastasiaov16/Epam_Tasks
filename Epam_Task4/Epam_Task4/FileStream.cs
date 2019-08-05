using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Epam_Task4
{
    internal class FileStream
    {
        public int Read()
        {
            Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            if(num < 0)
            {
                Console.Write("Enter the positive number: ");
                num = int.Parse(Console.ReadLine());
            }

            return num;
        }
    }
}
