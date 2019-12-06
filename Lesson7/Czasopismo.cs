using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Czasopismo : Pozycja
    {
        private int numer;
        
        public Czasopismo()
        {
            
        }

        public Czasopismo (int id, int numer, string tytul, string wydawnictwo, int rokWydania)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine($"Czasopismo: \n\n" +
                $"ID: {base.id}\n" +
                $"Numer wyd: {this.numer}\n" +
                $"Tytul: {base.tytul}\n" +
                $"Wydawnictwo: {base.wydawnictwo}\n" +
                $"Rok wydania: {base.rokWydania}\n");
        }
    }
}
