using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdev
{
    class Keci:Hayvan,IHayvan
    {
        private int urunMiktar;
        public int UrunUret(string durum)
        {
            if (durum == "Canlı")
            {
                urunMiktar += 1;
            }
            return urunMiktar;
        }
        public string Sesyolu(string yol)
        {
            return yol+"\\keci.wav";
        }
        public int UrunUcreti()
        {

            kasa = urunMiktar * 8;
            urunMiktar = 0;
            return kasa;
        }
       
    }
}
