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
            Console.WriteLine("1. Szolgáltató hozzáadása");
            Console.WriteLine("2. Szolgaltatok megjelenitese");
            Console.WriteLine("3. Kilepes");
            Console.WriteLine("4");
            string valasz = Console.ReadLine();
            switch (valasz){
                case "1":
                    SzolgaltatoView ujszolgaltato = new SzolgaltatoView();
                    new Szolgaltato()
                    {
                        Rovidnev = "ABC",
                        Nev = "ABCSzolgáltató Kft.",
                        Ugyfelszolgalat = "1066 Budapest, Jókai utca 1.",
                    };


                    break;
                case "2":
                    List<Szolgaltato> szolgaltatokListaja = new Controller.SzolgaltatoController().GetSzolgaltatoList();
                    new SzolgaltatoView().ShowSzolgaltatoList(szolgaltatokListaja);
                    break;
                case "3":
                    List<Szolgaltatas> szolgaltatasokListaja = new Controller.SzolgaltatasController().GetSzolgaltatasList();
                    new SzolgaltatasView().ShowSzolgaltatasList(szolgaltatasokListaja);
                    break;
                case "4":
                    List<Szamla> szamlaListaja = new Controller.SzamlaController().GetSzamlaList();
                    new SzamlaViews().ShowSzamlaList(szamlaListaja);
                    break;
            }
        }
    }
}
