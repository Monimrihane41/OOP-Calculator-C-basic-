using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcs c1 = new Calcs(7,3);
            Console.WriteLine(c1.Addition());
            Console.WriteLine(c1.Subtraction());
            Console.WriteLine(c1.Multiplication());
            Console.WriteLine(c1.Division());
            Console.WriteLine(c1.Modulo());

        }
    }
}
