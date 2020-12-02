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
            Console.WriteLine("ENTER YOUR NAME");
            string name = Console.ReadLine();

            Console.WriteLine("ENTER YOUR AGE");
            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + " Your " + age);

            Console.ReadLine();

        }
    }
}
