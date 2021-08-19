using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int anoDeEntrada;
            int resultado;
            Console.WriteLine("Digite o anoe que entrou na Empresa GFT");
            anoDeEntrada = Convert.ToInt32(Console.ReadLine());

            resultado = 2021 - anoDeEntrada;

            if (resultado==1)
            {
                Console.WriteLine("Parabens você ganhou um Vale Presente");
            }
            else if(resultado==2 )
            {
                Console.WriteLine("Parabens você ganhou um Smart Watch");
            }
            else if(resultado == 5 )
            {
                Console.WriteLine("Parabens você ganhou um Fone Bluetooth");
            }
            else if (resultado ==10 )
            {
                Console.WriteLine("Parabens você ganhou um Vale Jantar");
            }
            else if (resultado == 15 )
            {
                Console.WriteLine("Parabens você ganhou um Vale Jantar Top");
            }
            else
            {
                Console.WriteLine("Esse ano não vai ter presente");
            }
            Console.ReadKey();
        }
    }
}
