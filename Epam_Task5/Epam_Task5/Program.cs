using System;

namespace Epam_Task5
{
    internal class Program
    {
        private static void Main()
        {
            FileStream file = new FileStream();
            SearchLine line = new SearchLine();
            var str = file.Read();

            if (line.LineCheck(str))
                Console.WriteLine("Correct bracket sequence");
            else
                Console.WriteLine("Wrong bracket sequence");
        }
    }
}
