using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool banP = true;
            do
            {
                try
                {
                    Console.WriteLine("~~~¿Que programa desea realizar?~~~");
                    Console.WriteLine("Programa Numero mayor, ingrese (1) ");
                    Console.WriteLine("Programa Sucesion revetida, ingrese (2) ");
                    Console.WriteLine("Programa Numero menor, ingrese (3) ");
                    int menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            bool ban = true;
                            do
                            {
                                try
                                {
                                    int num;
                                    Console.Write("¿Cuantos numeros desea ingresar? ");
                                    num = Convert.ToInt32(Console.ReadLine());
                                    ValorMax Clase = new ValorMax();
                                    int[] vector = new int[num];
                                    for (int contador = 0; contador < num; contador++)
                                    {
                                        Console.Write("Ingrese valor {0}: ", (contador + 1));
                                        vector[contador] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.WriteLine("Mayor: " + Clase.Mayor(vector, 0, vector[0]));
                                    ban = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("No es un valor valido" + e.Message);
                                }
                            }
                            while (ban == true);
                            Console.ReadKey();
                            break;
                        case 2:
                            bool ban2 = true;
                            do
                            {
                                try
                                {
                                    string Suce;
                                    Console.Write("Ingrese Sucesion: ");
                                    Suce = Console.ReadLine();
                                    Reverse Clase = new Reverse();
                                    Console.Write("Sucesion Revertida: ");
                                    Clase.ReverseRecursivo(Suce);
                                    ban2 = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("No es un valor valido" + e.Message);
                                }
                            }
                            while (ban2 == true);
                            Console.ReadKey();
                            break;
                        case 3:
                            bool ban3 = true;
                            do
                            {
                                try
                                {
                                    int num;
                                    Console.Write("¿Cuantos numeros desea ingresar? ");
                                    num = Convert.ToInt32(Console.ReadLine());
                                    ValorMin Clase = new ValorMin();
                                    int[] vector = new int[num];
                                    for (int contador = 0; contador < num; contador++)
                                    {
                                        Console.Write("Ingrese valor {0}: ", (contador + 1));
                                        vector[contador] = Convert.ToInt32(Console.ReadLine());
                                    }
                                    Console.Write("Menor: " + Clase.Menor(vector, 0, vector[0]));
                                    ban3 = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("No es un valor valido" + e.Message);
                                }
                            }
                            while (ban3 == true);
                            Console.ReadKey();
                            break;
                    }
                    banP = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("No es un valor valido" + e.Message);
                }
            }
            while (banP == true) ;
            Console.ReadKey();
        }
    }
    class Reverse
    {
        public void ReverseRecursivo(string Suce)
        {
            if (Suce.Length > 0)
            {
                ReverseRecursivo(Suce.Substring(1, Suce.Length - 1));
            }
            else
            {
                return;
            }
            Console.Write(Suce[0]);
        }
    }
    class ValorMax
    {
        public int Mayor(int[] vector, int n, int mayor)
        {
            if (n == vector.Length)
            {
                return mayor;
            }
            else if (vector[n] > mayor)
            {
                mayor = vector[n];
            }
            return Mayor(vector, ++n, mayor);
        }
    }
    class ValorMin
    {
        public int Menor(int[] vector, int n, int menor)
        {
            if (n == vector.Length)
            {
                return menor;
            }
            else if (vector[n] < menor)
            {
                menor = vector[n];
            }
            return Menor(vector, ++n, menor);
        }
    }
}
