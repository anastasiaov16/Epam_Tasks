using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Task5
{
    internal class SearchLine
    {
        public bool LineCheck(string str1)
        {
            int opVal = 0, clVal = 0;

            str1.Split();
            for (var i = 0; i < str1.Length; i++)
            {
                if (str1[i] == '{' || str1[i] == '(' || str1[i] == '[')
                {
                    opVal++;
                }
                if (str1[i] == '}' || str1[i] == ')' || str1[i] == ']')
                {
                    clVal++;
                }
            }
            if (opVal == clVal)
                return true;
            else
                return false;
        }
    }
}
