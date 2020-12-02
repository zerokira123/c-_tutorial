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
         
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num2 + num1);

            Console.ReadLine();

        }
    }
}
