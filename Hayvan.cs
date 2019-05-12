using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace projeOdev
{
    public abstract class  Hayvan
    {

        protected int kasa;
        public string HayvanOldur(int progressBarValue)
        {
            if (progressBarValue == 0)
            {

            return "ölü";
            }
            return "Canlı";
        }
        public int YemVer(string hayvanDurumu)
        {
            if (hayvanDurumu == "Canlı")
            {
                return 100;
            }
            return 0;
        }
        public int HayvanCanEksilt(int progressbar,int miktar )
        {
            if (progressbar - miktar > 0)
            {
                return (progressbar - miktar);
            }
            return 0;
        }
        public  void SesCikar(string yol)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = yol;
            player.Play();
        }


    }
}
