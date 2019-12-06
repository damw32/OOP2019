using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    abstract class Pozycja
    {
        /*protected*/public string tytul;
        /*protected*/public int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja( string tytul, int id, string wydawnictwo, int rokWydania )
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        public Pozycja()
        {
            
        }

        abstract public void WypiszInfo();


    }
}
