using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_TP195_Temel
{
    internal class Ogrenci
    {
        public int No; //Get ve Set metotları ile bu özellikleri düzenleme seçeneğiniz var.
        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;
        public float Ortalama;
        public SUBE Sube;
        public CINSIYET Cinsiyet;
        public Adres Adres;

        public List<string> Kitaplar = new List<string>();

        public List<DersNotu> Notlar = new List<DersNotu>();
    }

    public enum SUBE 
    {
        Empty,
        A,
        B,
        C
    }

    public enum CINSIYET
    {
        Empty, Kiz, Erkek
    }
}
