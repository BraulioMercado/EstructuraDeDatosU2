using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2._1_Factorialrecursividad
{
    public class Program
    {
        int Factorial(int Fact)
        {
            if (Fact > 0)
            {
                int result = Fact * Factorial(Fact - 1);
                return result;
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            DateTime tiempo1 = DateTime.Now;
            Program re = new Program();
            int F = re.Factorial(6);
            Console.WriteLine("El factorial es:" + F);
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.Write("TIEMPO: " + total.ToString());
            Console.ReadKey();
        }
    }
}
