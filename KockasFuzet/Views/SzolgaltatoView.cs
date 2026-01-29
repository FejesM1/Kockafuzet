using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KockasFuzet.Models;
using Org.BouncyCastle.Security;

namespace KockasFuzet.Views
{
    internal class SzolgaltatoView
    {
        public SzolgaltatoView()
        {
        }

        static public void ShowSzolgaltato(Szolgaltato szolgaltato)
        {
            Console.WriteLine($"Rövid név: {szolgaltato.Rovidnev}");
            Console.WriteLine($"Név: {szolgaltato.Nev}");
            Console.WriteLine($"Ügyfélszolgálat");
            Console.WriteLine($"Cím: {szolgaltato.Ugyfelszolgalat}");
        }

        public void ShowSzolgaltatoList(List<Szolgaltato> szolgaltatolista)
        {
           Console.WriteLine("|--------+-------------------------------+--------------------------------------------|");
           Console.WriteLine("|Rövidnév| Név                           | Ügyfélszolgálat                            |");
           Console.WriteLine("|--------+-------------------------------+---Cím-------------------------|---Telefon--|");
            foreach (Szolgaltato szolgaltato in szolgaltatolista)
            {
                Console.WriteLine(SzolgaltatoRow(szolgaltato));
            }
           Console.WriteLine("|-----------------------+-------------------------------+-----------------------------|");
        }

        private static string SzolgaltatoRow(Szolgaltato szolgaltato)
        {
            string row = "|";
            row += szolgaltato.Rovidnev;
            row += new string(' ', 8 - szolgaltato.Rovidnev.Length) + "|";
            row += szolgaltato.Nev.Length < 30 ? szolgaltato.Nev + new string(' ', 30 - szolgaltato.Nev.Length+1) + "|" 
                : szolgaltato.Nev.Substring(0, 28) + "...|";
            row += szolgaltato.Ugyfelszolgalat.Length < 30 ? szolgaltato.Ugyfelszolgalat + new string(' ',30 - szolgaltato.Ugyfelszolgalat.Length+1) + "|            |" 
                : szolgaltato.Ugyfelszolgalat.Substring(0, 28) + "...|            |";

            return row;
        }
    }
}
