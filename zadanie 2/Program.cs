using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero
namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę całkowitą= ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba ta jest dodatnia");
            else if (a < 0)
                Console.WriteLine("Liczba ta jest ujemna");
            else
                Console.WriteLine("Liczba ta jest równa 0");
            Console.ReadKey(true);
        }
    }
}
