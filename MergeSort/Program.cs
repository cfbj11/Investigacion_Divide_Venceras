namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -2, 7, 0, 4, 2, 3, -3, 6, 5, -1 };
            Console.WriteLine("---Numeros Desordenados---");
            PrintArray(arr);

            MergeSort(arr);

            Console.WriteLine("---Numeros Ordenados---");
            PrintArray(arr);

        }

        static void PrintArray(int[] arr)
        {
            foreach (var dato in arr)
            {
                Console.WriteLine(dato);
            }
        }

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
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = derArr[j];
                j++; k++;
            }
        }


        static void mergeSort(int[] arr, int izq, int der)
        {
            if (izq < der)
            {
                int mitad = (izq + der) / 2;

                mergeSort(arr, izq, mitad);
                mergeSort(arr, mitad + 1, der);
                merge(arr, izq, mitad, der);
            }
        }

        static void MergeSort(int[] arr)
        {
            mergeSort(arr, 0, arr.Length - 1);
        }

    }
}