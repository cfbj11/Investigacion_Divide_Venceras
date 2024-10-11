using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        //  Funcion para encontrar el elemento realizando busqueda binaria
        static int BusqBin(int[] arreglo, int izq, int der, int dato)
        {
            if (der >= izq)
            {
                int med = izq + (der - izq) / 2;

                //  Si el elemento esta en el medio
                if (arreglo[med] == dato) return med;
                //  Si el elemento es mas pequeño, deberá estar en la mitad de la izquierda
                if (arreglo[med] > dato) return BusqBin(arreglo, izq, med - 1, dato);
                //  Si el elemento es mas grande, deberá estar en la mitad de la derecha
                return BusqBin(arreglo, med + 1, der, dato);
            }
            //  El elemento no se encuentra en el arreglo
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arreglo = { 2, 5, 7, 10, 12, 13, 15, 16, 18, 20};
            int result, dato;

            Console.WriteLine("Arreglo:");
            for (int i = 0; i < arreglo.Length; i++) { Console.Write(arreglo[i] + " "); }
            Console.Write($"\n\nElemento que se desea buscar: ");
            dato = Convert.ToInt32(Console.ReadLine());

            result = BusqBin(arreglo, 0, arreglo.Length - 1, dato);

            if (result != -1)
            {
                Console.WriteLine($"Posicion del elemento en el arreglo: {result}");
            } else Console.WriteLine("Elemento no encontrado.");

            Console.ReadKey();
        }
    }
}
