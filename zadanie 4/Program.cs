using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
//4. Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód. 
namespace zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pole jest równe {0}", a*b);
            Console.WriteLine("obwód jest równy {0}", 2*a + 2*b);
            Console.ReadKey(true);
        }
    }
}
