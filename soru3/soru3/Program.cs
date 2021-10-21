using System;

namespace soru3
{
    class Kisi
    {
        public Kisi(string ad, string soyad)
        {
            Console.WriteLine("Adınız : " + ad + "  Soyadınız : " + soyad);
        }
    }
    class Ogrenci : Kisi
    {
        public Ogrenci(string departman, string ad, string soyad)
        : base(ad, soyad)
        {
            Console.WriteLine("Departman : " + departman);
            //Base class Kisi olduğundan ilk kişi çalışır ad soyad alır yazar ve sonra ogrenciden departmanı yazar
        }
    }
    class Mudur : Kisi
    {
        public Mudur(string departman, string ad, string soyad)
        : base(ad, soyad)
        {
            Console.WriteLine("Departman : " + departman);
            //Base class Kisi olduğundan ilk kişi çalışır ad soyad alır
            //yazar sonra mudurden departmanı yazar
        }
    }
    class Program
    {
        static void Main()
        {
            Ogrenci o = new Ogrenci("Öğrenci", "Uğur", "Ören");
            //yukarıdaki metotlar constructor olduğundan instance
            //tanımlar gibi değerleri bu şekilde veriliyor
            Console.WriteLine();
            Mudur m = new Mudur("Müdür", "Ali", "Veli");
        }
    }
   

}
    