using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_TP195_Temel
{
    internal class Okul
    {
        public List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public void OgrenciEkle(int no,string ad,string soyad,DateTime dogumTarihi,SUBE sube, CINSIYET cinsiyet)
        {
            Ogrenci o = new Ogrenci();

            o.No = no;
            o.Ad = ad;

            //diğer bilgiler eklenecek...

            this.ogrenciler.Add(o);
        }

        public void NotEkle(int no, string dersAdi, int not)
        {
            Ogrenci o = ogrenciler.Where(a => a.No == no).FirstOrDefault();

            if (o != null)
            {
                o.Notlar.Add(new DersNotu(dersAdi, not));
            }
        }
    }
}
