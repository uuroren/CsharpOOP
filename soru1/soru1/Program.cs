using System;

namespace soru1
{
        class hayvansahiplenme
        {
            public string ad;
            public string soyad;
            public int tel;
            public int yas;
            public string adres;

         

        public void ozellikgoster()
            {

            Console.WriteLine("--Kişi Özellikleri--\nAdınız={0}\nSoyadınız={1}\nTelefon Numaranız={2}\nYaşınız={3}\nAdresiniz={4}", ad, soyad, tel,yas,adres);
            

            }
        }
        class kedisahipledirnme : hayvansahiplenme//hayvansahiplenme sınıfından kalıtım yapılan kedisahiplendirme sınıfı
        {
       
            public int kacaylik;
            public string asidurumu;
            public string cinsiyet;
            public string cins;
            public string ırk;
            public string sahiplendirmenedeni;
        public void kediozellik()
            {
                Console.WriteLine("Kaç Aylık={0}\nAşı Durumu={1}\n Cinsiyet={2}\n Irk={3}\nSahiplendirme Nedenini={4}", kacaylik,asidurumu,cinsiyet,ırk,sahiplendirmenedeni);
         
        }

        
        }
        class kopeksahiplendirme : hayvansahiplenme//hayvansahiplenme sınıfından kalıtım yapılan köpeksahiplendirme sınıfı
    {
    
        public int kacaylik;
        public string asidurumu;
        public string cinsiyet;
        public string cins;
        public string ırk;
        public string sahiplendirmenedeni;
        public void kopekozellik()
        {
            Console.WriteLine("Kaç Aylık={0}\nAşı Durumu={1}\n Cinsiyet={2}\n Irk={3}\nSahiplendirme Nedenini={4}", kacaylik, asidurumu, cinsiyet, ırk, sahiplendirmenedeni);
        }
    }
           
        class Program
        {
        static void Main(string[] args)
        {
            byte secim;
            kedisahipledirnme kedisahiplendirme = new kedisahipledirnme();
            kopeksahiplendirme kopeksahiplendirme = new kopeksahiplendirme();
            Console.WriteLine("*****************Lütfen Bir Seçim Yapınız******************");
            Console.WriteLine("1.Kedi Sahiplendirme");
            Console.WriteLine("2. Kopek Sahiplendirme");
            secim = Convert.ToByte(Console.ReadLine());
            if (secim == 1)
            {
                Console.Write("Adınızı Girin: ");
                kedisahiplendirme.ad = Console.ReadLine();
                Console.Write("Soyadınızı Girin: ");
                kedisahiplendirme.soyad = Console.ReadLine();
                Console.Write("Telefon Numaranızı Girin: ");
                kedisahiplendirme.tel = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adresinizi Giriniz: ");
                kedisahiplendirme.adres = Console.ReadLine();
                Console.Write("Yaşınızı Girin: ");
                kedisahiplendirme.yas = Convert.ToInt32(Console.ReadLine());          
                Console.Write("Kediniz Kaç Aylık: ");
                kedisahiplendirme.kacaylik = Convert.ToInt32(Console.ReadLine());
                Console.Write("Aşı Durumu: ");
                kedisahiplendirme.asidurumu = Console.ReadLine();
                Console.Write("Cinsiyet: ");
                kedisahiplendirme.cinsiyet = Console.ReadLine();
                Console.Write("Cins: ");
                kedisahiplendirme.cins = Console.ReadLine();
                Console.Write("Irk: ");
                kedisahiplendirme.ırk = Console.ReadLine();
                Console.Write("Sahiplendirme Nedeniniz?: ");
                kedisahiplendirme.sahiplendirmenedeni = Console.ReadLine();

                kedisahiplendirme.ozellikgoster();
                kedisahiplendirme.kediozellik();
              
            }
            else if (secim == 2)
            {
                Console.Write("Adınızı Girin: ");
                kopeksahiplendirme.ad = Console.ReadLine();
                Console.Write("Soyadınızı Girin: ");
                kopeksahiplendirme.soyad = Console.ReadLine();
                Console.Write("Telefon Numaranızı Girin: ");
                kopeksahiplendirme.tel = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yaşınızı Girin: ");
                kopeksahiplendirme.yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adresinizi Giriniz: ");
                kedisahiplendirme.adres = Console.ReadLine();
                Console.Write("Köpeğiniz Kaç Aylık: ");
                kopeksahiplendirme.kacaylik = Convert.ToInt32(Console.ReadLine());
                Console.Write("Aşı Durumu: ");
                kopeksahiplendirme.asidurumu = Console.ReadLine();
                Console.Write("Cinsiyet: ");
                kopeksahiplendirme.cinsiyet = Console.ReadLine();
                Console.Write("Cins: ");
                kopeksahiplendirme.cins = Console.ReadLine();
                Console.Write("Irk: ");
                kopeksahiplendirme.ırk = Console.ReadLine();
                Console.Write("Sahiplendirme Nedeniniz?: ");
                kopeksahiplendirme.sahiplendirmenedeni = Console.ReadLine();

                kopeksahiplendirme.ozellikgoster();
                kopeksahiplendirme.kopekozellik();
            }

            else
            {
                Console.WriteLine("Yanlış Bir Seçim Yaptınız");
            }
            Console.ReadKey();
            

        }
        
}
    }

