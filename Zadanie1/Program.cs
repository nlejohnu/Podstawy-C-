using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to liczba parzysta, czy też nieparzysta
namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę całkowitą= ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Liczba ta jest parzysta");
            else
                Console.WriteLine("Liczba ta jest nieparzysta");
            Console.ReadKey(true);

        }
    }
}
