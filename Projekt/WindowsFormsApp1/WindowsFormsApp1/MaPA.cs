using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Mapa : IMapa
    {
        public int x;
        public int y;
        void IMapa.generate()
        {
            int[,] mapka = new int[this.x, this.y];
        }

        void IMapa.list()
        {
            throw new NotImplementedException();
        }

        void IMapa.show()
        {
            throw new NotImplementedException();
        }
    }
}

    

