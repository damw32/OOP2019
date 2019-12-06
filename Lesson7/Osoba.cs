using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Osoba
    {
        /*protected*/public string imie;
        /*protected*/public string nazwisko;    

        public Osoba()
        {
           
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
