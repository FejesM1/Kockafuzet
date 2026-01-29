using KockasFuzet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockasFuzet.Views
{
    internal class SzolgaltatasView
    {
        public SzolgaltatasView()
        {
        }

        static public void ShowSzolgaltatas(Szolgaltatas szolgaltatas)
        {
            Console.WriteLine($"Rövid név: {szolgaltatas.Id}");
            Console.WriteLine($"Név: {szolgaltatas.Nev}");
            
        }

        public void ShowSzolgaltatasList(List<Szolgaltatas> szolgaltataslista)
        {
            Console.WriteLine("|-----------+------------------------------|");
            Console.WriteLine("|   Id      | Név                          |");
            Console.WriteLine("|-----------+------------------------------|");
            foreach (Szolgaltatas szolgaltatas in szolgaltataslista)
            {
                Console.WriteLine(SzolgaltatasRow(szolgaltatas));
            }
            Console.WriteLine("|-----------+------------------------------|");
        }

        private static string SzolgaltatasRow(Szolgaltatas szolgaltatas)
        {
            string row = "|";
            row += szolgaltatas.Id;
            row += new string(' ', 11 - szolgaltatas.Id.ToString().Length) + "|";
            row += szolgaltatas.Nev.Length < 30
                ? szolgaltatas.Nev + new string(' ', 30 - szolgaltatas.Nev.Length) + "|"
                : szolgaltatas.Nev.Substring(0, 27) + "...|";

            return row;
        }

    }
}
