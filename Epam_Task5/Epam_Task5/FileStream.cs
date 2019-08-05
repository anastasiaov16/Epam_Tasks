using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Epam_Task5
{
    internal class FileStream
    {
        public string Read()
        {
            using (StreamReader stream = new StreamReader("input.txt"))
            {
                return stream.ReadLine();
            }
        }
    }
}
