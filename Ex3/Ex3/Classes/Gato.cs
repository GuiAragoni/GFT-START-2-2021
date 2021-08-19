using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Classes
{
    class Gato: Animal
    {
        override public abstract void Som()
        {
            Console.WriteLine("miau");
        }
        override public abstract quantidadeDeRacao(int peso)
        {
            if (peso <= 4)
            {
                return 12 * peso;
            }
            else
            {
                return 15 * peso;
            }
        }
    }
}
