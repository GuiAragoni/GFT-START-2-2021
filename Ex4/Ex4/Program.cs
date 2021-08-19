using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Notas = { "Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si" };
            Console.WriteLine("Digite um número inicial:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número final:");
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i=x;i<=y;i++)
            {
                Console.WriteLine(Notas[x++]);
                if (i == 6) 
                {
                    x = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
