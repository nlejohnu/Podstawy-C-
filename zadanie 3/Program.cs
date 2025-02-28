using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb. 
namespace zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Podaj pierwszą liczbę= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj drugą liczbę= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę= ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a>b && a > c && b>c)
                Console.WriteLine("Liczba {0} jest największa, liczba {1} jest najmniejsza",a, c);
            else if (b>a && b > c && c>a)
                Console.WriteLine("Liczba {0} jest największa, liczba {1} jest najmniejsza", b, a);
            else if (a>b && a>c && b<c)
                Console.WriteLine("Liczba {0} jest największa, liczba {1} jest najmniejsza", a, b);
            else if (b > a && b > c && c < a)
                Console.WriteLine("Liczba {0} jest największa, liczba {1} jest najmniejsza", b, c);
            else if (c > a && c > b && a<b)
                Console.WriteLine("Liczba {0} jest największa, liczba {1} jest najmniejsza", c, a);
            else if (c > a && c > b && a > b)
                Console.WriteLine("Liczba {0} jest największa, liczba {1} jest najmniejsza", c, b);
            Console.ReadKey(true);

        }
    }
}
