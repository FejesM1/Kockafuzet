using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockasFuzet.Models
{
    internal class Szolgaltato
    {
        string nev;
        string rovidnev;
        string ugfelszolgalat;

        public string Nev { get => nev; set => nev = value; }
        public string Rovidnev { get => rovidnev; set => rovidnev = value; }
        public string Ugyfelszolgalat { get => ugfelszolgalat; set => ugfelszolgalat = value; }

        public Szolgaltato(string nev, string rovidnev, string ugfelszolgalat)
        {
            this.Nev = nev;
            this.Rovidnev = rovidnev;
            this.Ugyfelszolgalat = ugfelszolgalat;
        }

        public Szolgaltato() { }

        public override string ToString()
        {
            return $"Név: {Nev}, Rövid név: {Rovidnev}, Ügyfélszolgálat: {Ugyfelszolgalat}";
        }
    }
}
