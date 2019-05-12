using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdev
{
    class Tavuk : Hayvan, IHayvan
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

        public int UrunUcreti()
        {
            kasa = urunMiktar * 1;
            urunMiktar = 0;
            return kasa;
        }
        public string Sesyolu(string yol)
        {
            return  yol+"\\tavuk.wav";
        }
        
    }
}
