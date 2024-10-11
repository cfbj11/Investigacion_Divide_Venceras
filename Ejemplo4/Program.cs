using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4
{
    internal class Program
    {
        //  Funcion recursiva para encontrar el maximo y el minimo en un arreglo
        static (int, int) MaxMin(int[] arr, int izq, int der)
        {
            //  Si hay un solo elemento, ese es tanto el máximo como el mínimo.
            if (izq == der)
                return (arr[izq], arr[izq]);

            //  Si hay dos elementos, se comparan y se retornan el mayor y el menor.
            if (der == izq + 1)
            {
                if (arr[izq] > arr[der]) return (arr[izq], arr[der]);
                else return (arr[der], arr[izq]);
            }

            //  Encuentra el punto medio para dividir el arreglo en dos mitades.
            int mid = (izq + der) / 2;

            //  Llama recursivamente para encontrar el máximo y mínimo en las dos mitades.
            var (max1, min1) = MaxMin(arr, izq, mid);
            var (max2, min2) = MaxMin(arr, mid + 1, der);

            //  Devuelve el máximo y mínimo combinando los resultados de las dos mitades.
            return (Math.Max(max1, max2), Math.Min(min1, min2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Buscar Máximo y Mínimo usando Divide y Vencerás");

            Console.Write("Ingrese el tamaño del arreglo: ");
            int tam = int.Parse(Console.ReadLine());

            int[] arr = new int[tam];
            Console.WriteLine("Ingrese los elementos del arreglo:");
            for (int i = 0; i < tam; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            var (max, min) = MaxMin(arr, 0, arr.Length - 1);

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Máximo: {max}");
            Console.WriteLine($"Mínimo: {min}");

            Console.ReadKey();
        }
    }
}
