namespace OkulYonetimUygulamasi_TP195_Temel
{
    internal class Program
    {
        static Okul Okul = new Okul();
        static void Main(string[] args)
        {
            //Uygulama();
        }

        static void Uygulama()
        {
            //Menu
            //SecimAl
            //Switch-Case
        }

        static void NotGir()
        {
            try
            {
                Console.WriteLine("20-Öğrencinin notunu gir");
                Console.Write("Öğrencinin Numarası: ");
                int no = int.Parse(Console.ReadLine());

                //bu öğrencinin bilgileri bulunup yazdırılacak.

                string ders = Console.ReadLine(); //Hangi ders

                int adet = int.Parse(Console.ReadLine());



                for (int i = 1; i < adet; i++)
                {
                    Console.Write(i + ".notu giriniz :");
                    int not = int.Parse(Console.ReadLine());
                    Okul.NotEkle(no, ders, not);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        static void SahteVeriEkle()
        {
            Okul.OgrenciEkle(1, "Ali", "Soyad", new DateTime(2000, 5, 4), SUBE.B, CINSIYET.Erkek);

            //Başka öğrenciler de eklenecek.

            //Adres, Kitap , DersNotu gibi bilgiler için de sahte veri oluşturulmalı.
        }





    }
}
