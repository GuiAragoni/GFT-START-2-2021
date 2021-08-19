using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Classes
{
    abstract class Idioma
    {
        public String nomeDoIdioma { get; set; }
        public String saudacao { get; set; }
        public abstract void Saudacao();
        
    }
}