using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrer un nombre :");
            int p = Convert.ToInt32(Console.ReadLine());
            bool pr = true;
            while (p <= 0)
            {
                Console.WriteLine("entrer un nombre positif :");
                 p = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 2; i < p; i++)
            {
                if ((p % i) == 0)
                {
                    pr = false;
                    break;
                }
            }
            if (!pr)
            {
                Console.WriteLine(" ce nombre n'est pas premier ");
            }
            else
            {
                Console.WriteLine(" ce nombre est premier ");
            }
        }
    }
}
