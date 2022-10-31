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
            int p = Console.ReadLine();

            while (p < 0)
            {
                Console.WriteLine("entrer un nombre positif :");
                int n = Console.ReadLine();
            }
            int r;
            for (int i = 2; i < p; i++)
            {
                if ((p % i) == 0)
                {
                    
                    r++;
                }
            }
             if (r > 0)
            {
                Console.WriteLine(p + "ce nombre n'est pas premier ");
                
            }
            else
            {
                Console.WriteLine(p + "ce nombre est premier ");
            }
        }
    }
}
