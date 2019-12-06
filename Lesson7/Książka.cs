using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;

        Autor autor = new Autor();

        public Ksiazka()
        {

        }

        public Ksiazka( int id, string tytul, string wydawnictwo, int rokWydania, int liczbaStron)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine($"Autor: \n" +
                $"Imie: {autor.imie}\n" +
                $"Nazwisko: {autor.nazwisko}\n" +
                $"Narodowosc: {autor.narodowosc}\n" +
                $"\n" +
                $"Ksiazka:\n" +
                $"ID: {base.id}\n" +
                $"Tytul: {base.tytul}\n" +
                $"Wydawnictwo: {base.wydawnictwo}\n" +
                $"Rok wydania: {base.rokWydania}\n" +
                $"Liczba stron: {this.liczbaStron}\n");
        }
    }


        
}
