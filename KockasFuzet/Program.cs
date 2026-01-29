using KockasFuzet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KockasFuzet.Models;
using System.Runtime.InteropServices;


namespace KockasFuzet
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Nyomj egy szamot");
            Console.WriteLine("1. Adott szolgáltató megjelenítése");
            Console.WriteLine("2. Szolgáltatók megjelenítése");
            Console.WriteLine("3. Adott szolgáltatás megjelenítése");
            Console.WriteLine("4. Szolgáltatások megjelenítése");
            Console.WriteLine("5. Adott számla megjelenítése");
            Console.WriteLine("6. Számlák megjelenítése");
            string valasz = Console.ReadLine();
            switch (valasz){
                case "1":
                    SzolgaltatoView view = new SzolgaltatoView();
                    Szolgaltato sz = new Szolgaltato()
                    {
                        Rovidnev = "ABC",
                        Nev = "ABCSzolgáltató Kft.",
                        Ugyfelszolgalat = "1066 Budapest, Jókai utca 1."
                    };
                    SzolgaltatoView.ShowSzolgaltato(sz);
                    break;
                case "2":
                    List<Szolgaltato> szolgaltatokListaja = new Controller.SzolgaltatoController().GetSzolgaltatoList();
                    new SzolgaltatoView().ShowSzolgaltatoList(szolgaltatokListaja);
                    break;
                case "3":
                    SzolgaltatoView view2 = new SzolgaltatoView();
                    Szolgaltatas sz2 = new Szolgaltatas()
                    {
                        Id = 1,
                        Nev = "Viz",
                    };
                    SzolgaltatasView.ShowSzolgaltatas(sz2); 
                    break;
                case "4":
                    List<Szolgaltatas> szolgaltatasokListaja = new Controller.SzolgaltatasController().GetSzolgaltatasList();
                    new SzolgaltatasView().ShowSzolgaltatasList(szolgaltatasokListaja);
                    break;
                case "5":
                    SzamlaViews view3 = new SzamlaViews();
                    Szamla sz3 = new Szamla()
                    {
                        Id = 1,
                        Szolgaltatasazon = 1,
                        Szolgaltatorovid = "ABC",
                        Tol = DateTime.Now,
                        Ig = DateTime.Now.AddMonths(1),
                        Osszeg = 10000,
                        Hatarido = DateTime.Now.AddMonths(1).AddDays(15),
                        Befizetve = DateTime.Parse("2026-01-31"),
                        Megjegyzes = "Első számla"
                    };
                    SzamlaViews.ShowSzamla(sz3);
                    break;
                case "6":
                    List<Szamla> szamlaListaja = new Controller.SzamlaController().GetSzamlaList();
                    new SzamlaViews().ShowSzamlaList(szamlaListaja);
                    break;
            }
        }
    }
}
