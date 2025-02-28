using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej największej z tych liczb. 
namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, min, max;
            Console.Write("podaj pierwszą liczbę");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj drugą liczbę");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj trzecią liczbę");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj czwartą liczbę");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj piątą liczbę");
            e = Convert.ToInt32(Console.ReadLine());
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Najmniejsza liczba to {0},", min);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Największa liczba to {0}", max);
            Console.ReadKey(true);  



        }
    }
}
