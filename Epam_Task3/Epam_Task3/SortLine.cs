using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task3
{
    internal class SortLine
    {
        public List<string> SortLines(List<string> line1)
        {
            line1.Sort();

            for (var i = 0; i < line1.Count - 1; i++)
            {
                if (line1[i] == line1[i + 1])
                {
                    line1.RemoveAll(t => t == line1[i]);
                }
            }

            return line1;
        }
    }
}
