using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IMapa
    {
        public void generate();//generowanie mapy na podstawie podanych wymiarów
        public void list(); //wyśœietlenie informacji na temat każdego elementu dodanego do mapy
        public void show(); // wyświetlenie mapy
    }
}
