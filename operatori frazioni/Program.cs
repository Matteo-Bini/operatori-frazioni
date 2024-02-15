using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frazioni;

namespace operatori_frazioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 5);
            Fraction f2 = new Fraction(2, 5);
            Console.WriteLine(f1 <= f2);
            Console.ReadLine();
        }
    }
}
