using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task3
{
    internal class Program
    {
        private static void Show(List<string> res)
        {
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }
        private static void Main(string[] args)
        {
            FileStream file = new FileStream();
            SortLine line = new SortLine();

            var res = line.SortLines(file.Read());
            Show(res);            
        }
    }
}
