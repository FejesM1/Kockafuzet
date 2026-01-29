using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockasFuzet.Models
{
    internal class Szamla
    {
        int id;
        int szolgaltatasazon;
        string szolgaltatorovid;
        DateTime tol;
        DateTime ig;
        int osszeg;
        DateTime hatarido;
        DateTime befizetve;
        string megjegyzes;
        public Szamla(int id, int szolgaltatasazon, string szolgaltatorovid, DateTime tol, DateTime ig, int osszeg, DateTime hatarido, DateTime befizetve, string megjegyzes)
        {
            this.id = id;
            this.szolgaltatasazon = szolgaltatasazon;
            this.szolgaltatorovid = szolgaltatorovid;
            this.tol = tol;
            this.ig = ig;
            this.osszeg = osszeg;
            this.hatarido = hatarido;
            this.befizetve = befizetve;
            this.megjegyzes = megjegyzes;
        }
        public Szamla() { }

        public int Id { get { return id; } set { id = value; } }
        public int Szolgaltatasazon { get { return szolgaltatasazon; } set { szolgaltatasazon = value; } }
        public string Szolgaltatorovid { get { return szolgaltatorovid; } set { szolgaltatorovid = value; } }
        public DateTime Tol { get { return tol; } set { tol = value; } }
        public DateTime Ig { get { return ig; } set { ig = value; } }
        public int Osszeg { get { return osszeg; } set { osszeg = value; } }
        public DateTime Hatarido { get { return hatarido; } set { hatarido = value; } }
        public DateTime Befizetve { get { return befizetve; } set { befizetve = value; } }
        public string Megjegyzes { get { return megjegyzes; } set { megjegyzes = value; } }
    }
}
