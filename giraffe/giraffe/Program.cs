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
            string[] fr = new string[5];
            fr[0] = "zero";

            Console.WriteLine(luckynumbers[2] + fr[0]);

            Console.ReadLine();

        }
    }
}
