using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DLL
{
    public class Class1
    {
        public int Topla (int deger1, int deger2)
        {
            return deger1 + deger2;
        }

        public int Cikar(int deger1, int deger2)
        {
            return deger1 - deger2;
        }

        public int Carp(int deger1, int deger2)
        {
            return deger1 * deger2;
        }

        public int Bol(int deger1, int deger2)
        {
            if (deger2==0)
            {
                deger2 = 1;
            }
            return deger1 / deger2;
        }

        
    }
}
