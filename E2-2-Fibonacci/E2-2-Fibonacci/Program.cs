using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2_Fibonacci
{
    class Fibonacci
    {
        public int FibonacciIterativo(int n)
        {
            int n1 = 1;
            int n2 = 1;
            if (n==0)
            {
                return 0;
            }
            for (int i = 2; i <= n; i++)
            {
                int n2Aux = n1 + n2;
                n1 = n2;
                n2 = n2Aux;
            }
            return n1;

        }
        public int FibonacciRecursivo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {

                return 1;
            }
            else
            {
                return FibonacciRecursivo(n - 2) + FibonacciRecursivo(n - 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Fibonacci Clase = new Fibonacci();

            Console.Write("Ingresar la cantidad de terminos: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("~~Fibonacci recursivo~~");
            Stopwatch tiempo = Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Fibonnaci posicion " + (i + 1) + " es: " + Clase.FibonacciRecursivo(i));

            }
            Console.WriteLine("Tiempo: " + tiempo.Elapsed.TotalMilliseconds + " milisegundos");

            Console.WriteLine("~~Fibonacci Iterativo~~");
            Stopwatch tiempo2 = Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Fibonnaci posicion " + (i +1) + " es: " + Clase.FibonacciIterativo(i));

            }
            Console.WriteLine("Tiempo: " + tiempo2.Elapsed.TotalMilliseconds + " milisegundos");
            Console.ReadKey();
        }
    }
}