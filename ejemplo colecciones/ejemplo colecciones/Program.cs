using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ejemplo_colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Coleccion nombres = new Coleccion();
            nombres.Add("Cesar");
            nombres.Add("Julio");
            nombres.Add("Arturo");
            nombres.Add(2);

            foreach (var item in nombres)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
            Console.WriteLine(nombres.Count());
            Console.ReadKey();
            nombres.Remove("Arturo");
            Console.WriteLine(nombres.Count());
            Console.ReadKey();
            nombres.Clear();
            Console.WriteLine(nombres.Count());
            Console.ReadKey();

            //~~~~~~~~~~~~~~~~~~~~~~

            ArrayList lista = new ArrayList();
            lista.Add("Pedro");
            lista.Add("Goku");
            lista.Add("Jiren");
            lista.Add("Raso");

            if(lista.Contains("Pedro"))
            {
                Console.WriteLine("Si aparece aqui");
            }
            Console.ReadKey();
            lista.Sort();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            lista.Reverse();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
