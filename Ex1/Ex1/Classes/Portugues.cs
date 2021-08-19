using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Classes
{
    class Portugues:Idioma
    {
        public abstract void Saudacao()
        {
            Console.WriteLine("Olá Mundo");
        }
    }
}
