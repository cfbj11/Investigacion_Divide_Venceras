using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        //  Funcion para imprimir los elementos del arreglo
        static void ImprimirArr(int[] arr)
        {
            foreach (var dato in arr)
            {
                Console.Write(dato + " ");
            }
        }

        //  Funcion para combinar los dos sub-arreglos ordenados en un solo
        static void merge(int[] arr, int izq, int mitad, int der)
        {
            int n1 = mitad - izq + 1;
            int n2 = der - mitad;

            int[] izqArr = new int[n1];
            int[] derArr = new int[n2];

            Array.Copy(arr, izq, izqArr, 0, n1);
            Array.Copy(arr, mitad + 1, derArr, 0, n2);

            int i = 0, j = 0;
            int k = izq;

            while (i < n1 && j < n2)
            {
                if (izqArr[i] <= derArr[j])
                {
                    arr[k] = izqArr[i];
                    i++;
                }
                else
                {
                    arr[k] = derArr[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = izqArr[i];
                i++; k++;
            }

            while (j < n2)
            {
                arr[k] = derArr[j];
                j++; k++;
            }
        }

        //  Funcion recursiva para implementar el algoritmo Merge Sort
        static void mergeSort(int[] arr, int izq, int der)
        {
            if (izq < der)
            {
                int mitad = izq + (der - izq) / 2;

                mergeSort(arr, izq, mitad);
                mergeSort(arr, mitad + 1, der);
                merge(arr, izq, mitad, der);
            }
        }

        //  Funcion para ordenar el arreglo completo
        static void MergeSort(int[] arr)
        {
            mergeSort(arr, 0, arr.Length - 1);
        }

        static void Main()
        {
            int[] arr = { 8, 1, 7, 4, 2, 3, 10, 6, 5, 9 };
            Console.WriteLine("Numeros Desordenados:");
            ImprimirArr(arr);

            MergeSort(arr);

            Console.WriteLine("\n\nNumeros Ordenados");
            ImprimirArr(arr);

            Console.ReadKey();
        }
    }
}
