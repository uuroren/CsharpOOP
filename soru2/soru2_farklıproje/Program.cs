using System;

namespace soru2_farklıproje
{
    // ilk olarak bir değişken tanımladık
    interface ISiralama
    {
        int sonrakiSayi();
        void sifirla();
        void Ayarla(int a);
    }

    class beslisayiyazdir : ISiralama // classla ınterfacesimizi implement ettik.

    {
        // Değişken oluştur.
        int deger;
        int baslangic;
        int onceki;

        // baslangic değeri
        public beslisayiyazdir()
        {
            baslangic = 0;
            deger = 0;

        }

        
        // beşerli artaracak ve sonraki sayıyı bulacak metod
        #region ISiralama Sayilar  //region: kodların okunurluğu arttırmak ve daha düzenli bir yapıda görünmesini sağlamak için kullanılır.
        public int sonrakiSayi()
        {
            onceki = deger;
            deger += 5;
            return deger;

        }

        //sayıyı sıfırlama metodu
        public void sifirla()
        {
            deger = baslangic;
            onceki = baslangic - 5;

        }

        // sayıyı istenen değerden başlayarak sayacak olan metod
        public void Ayarla(int a)
        {
            baslangic = a;
            deger = baslangic;
            onceki = deger - 5;
        }
        #endregion

        public int oncekiSayi()
        {
            return onceki;
        }


    }
    class Program
    {

        static void Main(string[] args)
        {

            // nesne tanımladık.
            beslisayiyazdir sayi = new beslisayiyazdir();

            // beşerli şekilde 0 dan 10 defa artarak sayılara yazacak sonuç 5-50 .
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(sayi.sonrakiSayi());
            }
            // burda tekrar sıfırlıyorum. Bu sefer 20 defa 5er 5er arttırarak yazdırcam, sonuç 5-100 arası.
            sayi.sifirla();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(sayi.sonrakiSayi());
            }
            // başlangıcı 200 ayarlıyıp 5 erli 5 erli arttırıyorum. Sonuç 205 - 225 

            sayi.Ayarla(200);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayi.sonrakiSayi());
            }

            //Son olarak gelen son sayı 225 bir önceki sayı metodumu çağırıyorum bu sefer sonuç 220 olarak kalıcak.
            Console.WriteLine(sayi.oncekiSayi());
            Console.ReadLine();

        }
    }
}
    

