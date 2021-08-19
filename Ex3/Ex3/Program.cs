using Ex3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gata1 = new Gato();
            gata1.Nome="Coca";
            gata1.Peso = 20;
            Gato gata2 = new Gato();
            gata2.Nome = "Foxy";
            gata2.Peso = 3;
            Gato gata3 = new Gato();
            gata3.Nome = "Edward";
            gata3.Peso = 5;
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Einstein";
            cachorro1.Peso = 10;
        }
    }
}
