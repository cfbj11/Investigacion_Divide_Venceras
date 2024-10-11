using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        //  Funcíon para verificar que el numero ingresado contiene tres digitos
        static int Verificar(int n)
        {
            if (n >= 100 && n <= 999)
            {
                return n;
            }
            return 0;
        }

        //  Funcion para obtener el primer digito del numero ingresado
        static int PriDig(int n) { return (n / 100) % 10; }

        //  Funcion para obtener el segundo digito del numero ingresado
        static int SegDig(int n) { return (n / 10) % 10; }

        //  Funcion para obtener el tercer digito del numero ingresado
        static int TerDig(int n) { return n % 10; }

        //  Funcion para calcular la suma de los tres numeros
        static int Suma(int n) { return PriDig(n) + SegDig(n) + TerDig(n); }

        //  Funcion para solicitar el numero al usuario y mostrar el resultado de la suma
        static void Resultados()
        {
            Console.WriteLine("Digite un numero de tres digitos.");
            Console.Write("Numero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (Verificar(n) == n)
            {
                Console.WriteLine($"La suma de los tres digitos es: {Suma(n)}");
            }
            else
            {
                Console.WriteLine("ERROR: El numero digitado no es de tres digitos.");
            }
        }

        static void Main(string[] args)
        {
            Resultados();
            Console.ReadKey();
        }
    }
}
