using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdev
{
    class Inek : Hayvan, IHayvan
    {
        private int urunMiktar;
        public string Sesyolu(string yol)
        {

            return yol + "\\inek.wav";
        }

        public int UrunUret(string durum)
        { 
            if(durum=="Canlı"){
        
            urunMiktar += 1;
            }
            return urunMiktar; 
        }
        public int UrunUcreti()
        {
            kasa = urunMiktar * 5;
            urunMiktar = 0;
            return kasa;
        }
       

    }
}
