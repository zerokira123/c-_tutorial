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
            string chName = Console.ReadLine();
            int intAge = 20;

            Console.WriteLine("There was once a man named " + chName);
            Console.WriteLine("He was " +intAge+ " Years old");
            Console.WriteLine("he realy liked the Name " + chName);
            Console.WriteLine("but he didn't like being " + intAge);
            Console.ReadLine();

        }
    }
}
