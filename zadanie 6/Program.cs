using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i iloraz. 
namespace zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("podaj pierwszą liczbę=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj drugą liczbę=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("suna tych liczb to {0}", a + b);
            Console.WriteLine("różnica tych liczb to {0}", a-b);
            Console.WriteLine("iloczyn tych liczb to {0}", a*b);
            Console.WriteLine("iloraz tych liczb to {0}", a/b);
            Console.ReadKey(true);

        }
    }
}
