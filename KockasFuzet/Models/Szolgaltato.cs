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

        public Szolgaltato(string nev, string rovidnev, string ugfelszolgalat)
        {
            this.nev = nev;
            this.rovidnev = rovidnev;
            this.ugfelszolgalat = ugfelszolgalat;
        }

        public Szolgaltato() { }

        public override string ToString()
        {
            return $"Név: {nev}, Rövid név: {rovidnev}, Ügyfélszolgálat: {ugfelszolgalat}";
        }
    }
}
