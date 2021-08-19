using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Classes
{
    class Cachorro : Animal
    {
        override public abstract void Som()
        {
            Console.WriteLine("auau");
        }
        override public abstract int quantidadeDeRacao(int peso)
        {
            if (peso <= 3)
            {
                return 35 * peso;
            }
            else if (peso >3 && peso <=10)
            {
                return 45 * peso;
            }
            else
            {
                return 50 * peso;
            }
        }


    }
}
