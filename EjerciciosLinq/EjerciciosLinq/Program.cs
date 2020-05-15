using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // int suma = x.Sum();
            var lista = new List<int> { 1,2,3,4,5};
            var pares = x.Where(p => p % 2 == 0);

            //Console.WriteLine("Suma : " + suma);
            Console.WriteLine("Pares : " + pares);
            Console.ReadLine();
        }
    }
}
