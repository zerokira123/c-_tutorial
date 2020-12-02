using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckynumbers = { 44, 4, 48, 8, 88 };

            luckynumbers[2] = 90;

            Console.WriteLine(luckynumbers[2]);

            Console.ReadLine();

        }
    }
}
