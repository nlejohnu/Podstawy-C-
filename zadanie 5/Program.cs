using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na ekranie objętość i pole całkowite tego stożka. 
namespace zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, h, l;
            Console.Write("podaj promień podstawy=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj wysokość stożka=");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r*r + h * h);
            Console.WriteLine("Objętość jest równa {0}", (Math.PI*r*r)/3);
            Console.WriteLine("Pole całkowite stożka wynosi {0}", Math.PI * r*(r + l));
            Console.ReadKey(true); 
        }
    }
}
