using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    interface IZarzadzanieKatalogiem
    {
        void WyszukajPoTytule(string potytule);
        void WyszukajPoId(int poid);
        void WypiszWszystko();
        
    }
}
