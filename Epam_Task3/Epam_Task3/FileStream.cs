using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Epam_Task3
{
    internal class FileStream
    {
        public List<string> Read()
        {
            using (StreamReader stream = new StreamReader("input.txt", Encoding.Default))
            {
                char[] delitel = { ' ', '.', ',', '-', '?', '!', ':', ';', '"', '@' };
                List<string> line1 = stream.ReadLine().ToLower().Split(delitel, StringSplitOptions.RemoveEmptyEntries).ToList();

                return line1;
            }           
        }

    }
}
