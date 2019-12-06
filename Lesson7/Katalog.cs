using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Katalog : IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;

        public List<Pozycja> listaPozycji = new List<Pozycja>();

        

        public Katalog()
        {

        }

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            this.listaPozycji.Add(pozycja);
        }

        public void WypiszWszystko()
        {
            foreach(Pozycja lista in listaPozycji)
            {
                Console.WriteLine(lista);
            }
        }

        public void WyszukajPoId(int poid)
        {
            foreach (Pozycja i in listaPozycji)
            {
                if (i.id == poid)
                    i.WypiszInfo();
            }
        }

        public void WyszukajPoTytule(string potytule)
        {
            foreach(Pozycja i in listaPozycji)
            {
                if(i.tytul == potytule)
                {
                    i.WypiszInfo();
                }
            }
        }
    }
}
