using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace projeOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        Inek inek = new Inek();
        Keci keci = new Keci();
        Tavuk tavuk = new Tavuk();
        Ordek ordek = new Ordek();
        int kasa=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //oyunun başlaması ve ilk durumda hayvanların canlarının tam olmasını sağlıyor.
            timer1.Start();
            prgs_inek.Value = 100;
            prgs_keci.Value = 100;
            progress_tavuk.Value = 100;
            progres_ordek.Value = 100;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            
            lblZaman.Text = sayac.ToString() + "sn";
            //<summary>
            //    Hayvanların anlık olarak enejisini azaltmak için oluşturuldu.
            //</summary>
            prgs_inek.Value= inek.HayvanCanEksilt(prgs_inek.Value, 8);
            prgs_keci.Value = keci.HayvanCanEksilt(prgs_keci.Value,6);
            progress_tavuk.Value = tavuk.HayvanCanEksilt(progress_tavuk.Value, 2);
            progres_ordek.Value = ordek.HayvanCanEksilt(progres_ordek.Value, 3);

            //<summary>
            //    hayvanların anlıkk yaşam durumları kontrol ediliyor
            //</summary>
            lbl_inek.Text=inek.HayvanOldur(prgs_inek.Value);
            lbl_keci.Text = keci.HayvanOldur(prgs_keci.Value);
            lbl_tavuk.Text = tavuk.HayvanOldur(progress_tavuk.Value);
            lbl_ordek.Text = ordek.HayvanOldur(progres_ordek.Value);
            if(sayac%3==0)
            lbl_tYumurtaSayisi.Text = tavuk.UrunUret(lbl_tavuk.Text).ToString() + "Adet";
            if(sayac%8==0)
                lbl_inekSutu.Text = inek.UrunUret(lbl_inek.Text).ToString() + "KG";
            if (sayac % 7 == 0)
                lbl_keciSut.Text = keci.UrunUret(lbl_keci.Text).ToString() + "KG";
            if (sayac % 5 == 0)
                lbl_ordekYadet.Text = ordek.UrunUret(lbl_ordek.Text).ToString() + "Adet";

        }
        //<summary>
       // Hayvanların canlı durumu ölü durumuna geçtiğinde tetiklenmesi için yazıldı
       // </summary>
        private void lbl_inek_TextChanged(object sender, EventArgs e)
        {
            inek.SesCikar(inek.Sesyolu(Application.StartupPath));
        }

        private void lbl_keci_TextChanged(object sender, EventArgs e)
        {
            keci.SesCikar(keci.Sesyolu(Application.StartupPath));
        }

        private void lbl_tavuk_TextChanged(object sender, EventArgs e)
        {
            tavuk.SesCikar(tavuk.Sesyolu(Application.StartupPath));
        }

        private void lbl_ordek_TextChanged(object sender, EventArgs e)
        {
            ordek.SesCikar(ordek.Sesyolu(Application.StartupPath));
        }
        //<summary>
        //    Hayvanlara yem vermek için oluşturuldu.
        //</summary>
        private void btn_inek_Click(object sender, EventArgs e)
        {
            prgs_inek.Value = inek.YemVer(lbl_inek.Text);
        }
        private void btn_keci_Click(object sender, EventArgs e)
        {
            prgs_keci.Value = keci.YemVer(lbl_keci.Text);
        }

        private void btn_tavuk_Click(object sender, EventArgs e)
        {
            progress_tavuk.Value = tavuk.YemVer(lbl_tavuk.Text);
        }

        private void btn_ordek_Click(object sender, EventArgs e)
        {
            progres_ordek.Value = ordek.YemVer(lbl_ordek.Text);
        }

      

        private void btn_tYumurtaSat_Click(object sender, EventArgs e)
        {
            lbl_tYumurtaSayisi.Text = "0 Adet";
            kasa += tavuk.UrunUcreti();
            lbl_kasa.Text = kasa.ToString() + "TL"; 
                
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbl_ordekYadet.Text = "0 Adet";
            kasa += ordek.UrunUcreti();
            lbl_kasa.Text =kasa.ToString()+"TL" ;
            
        }

        private void btn_inekSutSat_Click(object sender, EventArgs e)
        {
            lbl_inekSutu.Text = "0 KG";
            kasa += inek.UrunUcreti();
            lbl_kasa.Text = kasa.ToString() + "TL";
        }

        private void btn_KsutuSat_Click(object sender, EventArgs e)
        {
            lbl_keciSut.Text = "0 KG";
            kasa += keci.UrunUcreti();
            lbl_kasa.Text = kasa.ToString() + "TL";
        }
    }
}
