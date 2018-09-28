using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2._1_Factorial
{
    class Program
    {
        public int Operaciones()
        {
            int Fact = 1;
            int Cont;
            for (Cont = 1; Cont <= 6; Cont++)
            {
                Fact = Fact * Cont;
            }
            return Fact;
        }
        static void Main(string[] args)
        {
            DateTime tiempo1 = DateTime.Now;
            Program Fact = new Program();
            Console.WriteLine("El resultado es {0} ", Fact.Operaciones());
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.Write("TIEMPO: " + total.ToString());
            Console.ReadKey();
        }
    }
}
