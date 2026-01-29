using KockasFuzet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockasFuzet.Views
{
    internal class SzamlaViews
    {
        public SzamlaViews()
        {
        }

        static public void ShowSzamla(Szamla szamla)
        {
            Console.WriteLine($"Id: {szamla.Id}");
            Console.WriteLine($"Szolgáltatás azonosító: {szamla.Szolgaltatasazon}");
            Console.WriteLine($"Szolgáltató rövid: {szamla.Szolgaltatorovid}");
            Console.WriteLine($"Tól: {szamla.Tol}");
            Console.WriteLine($"Ig: {szamla.Ig}");
            Console.WriteLine($"Összeg: {szamla.Osszeg}");
            Console.WriteLine($"Határidő: {szamla.Hatarido}");
            Console.WriteLine($"Befizetve: {szamla.Befizetve}");
            Console.WriteLine($"Megjegyzés: {szamla.Megjegyzes}");
        }


        public void ShowSzamlaList(List<Szamla> szamlaLista)
        {
            Console.WriteLine("|----+-----------------+----------------+------------+------------+--------+------------+------------+----------------|");
            Console.WriteLine("| Id |SzolgáltatásAzon | SzolgáltatóRöv | Tól        | Ig         | Összeg | Határidő   | Befizetve  | Megjegyzés     |");

            foreach (Szamla sz in szamlaLista)
            {
                Console.WriteLine(SzamlaRow(sz));
            }

            Console.WriteLine("|----+-----------------+----------------+------------+------------+--------+------------+------------+----------------|");
        }

        private static string SzamlaRow(Szamla sz)
        {
            string row = "|";

            row += sz.Id;
            row += new string(' ', 4 - sz.Id.ToString().Length) + "|";

            row += sz.Szolgaltatasazon;
            row += new string(' ', 17 - sz.Szolgaltatasazon.ToString().Length) + "|";

            row += sz.Szolgaltatorovid;
            row += sz.Szolgaltatorovid.Length < 16
                ? new string(' ', 16 - sz.Szolgaltatorovid.Length) + "|"
                : "...|";

            row += sz.Tol.ToString("yyyy-MM-dd");
            row += new string(' ', 12 - sz.Tol.ToString("yyyy-MM-dd").Length) + "|";

            row += sz.Ig.ToString("yyyy-MM-dd");
            row += new string(' ', 12 - sz.Ig.ToString("yyyy-MM-dd").Length) + "|";

            row += sz.Osszeg;
            row += new string(' ', 8 - sz.Osszeg.ToString().Length) + "|";

            row += sz.Hatarido.ToString("yyyy-MM-dd");
            row += new string(' ', 12 - sz.Hatarido.ToString("yyyy-MM-dd").Length) + "|";

            row += sz.Befizetve.ToString("yyyy-MM-dd");
            row += new string(' ', 12 - sz.Befizetve.ToString("yyyy-MM-dd").Length) + "|";

            row += sz.Megjegyzes;
            row += sz.Megjegyzes.Length < 16
                ? new string(' ', 16 - sz.Megjegyzes.Length) + "|"
                : "...|";

            return row;
        }


    }
}
