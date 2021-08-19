using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Classes
{
    public abstract class Animal
    {
        public String Nome;
        public int Peso;

        public Animal(String nome, int peso)
        {
            this.Nome = nome;
            this.peso = peso;
        }
        public abstract void Som();
        public abstract int quantidadeDeRacao(int peso);

    }
}
