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
            string color, pluralnoun, celebrity;

            Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            pluralnoun = Console.ReadLine();

            Console.WriteLine("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralnoun +" are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();

        }
    }
}
