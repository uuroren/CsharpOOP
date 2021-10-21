using System;

namespace soru2
{
    public interface IIslem // ınterface 
    {
        void topla(int sayi1, int sayi2);
        void carp(int sayi1, int sayi2);
    }
    public class Hesap : IIslem 
    {
        public void carp(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + "*" + sayi2 + "=" + sayi1 * sayi2);
        }

        public void topla(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + "+" + sayi2 + "=" + (sayi1 + sayi2));
        }
    }
    class Program
    {
         static void Main(string[] args)
        {
            Hesap hesap = new Hesap();

            hesap.topla(7, 5);
            hesap.carp(4, 3);

            Console.ReadLine();
        }
    }
    }

