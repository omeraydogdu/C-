using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaTemelleri
{
    class Degiskenler
    {
        public static void Calistir()
        {
            // tamsayı (byte,short,int,long)

            int sayi = 10;
            int sayi2 = 20;

            long sayi3 = 50;
            short sayi4 = 5;
            byte sayi5 = 10;

            // ondalıklı
            float a = 10.5f;
            double b = 20.6;
            decimal c = 100.56m;

            // karakter
            string name = "abdullah akyol";
            char ch = 'a';

            // boolean
            bool isRetired = true;
            bool isActive = false;

            Console.WriteLine(sayi);
            Console.WriteLine(sayi2);

            // null
            // nullable

            //* Kilo bilgisi tutacak bir değişken (byte,short,int,long) 
            byte? kilo = null;

            //* Plaka bilgisi tutacak bir değişken 
            byte plaka = 81;
            string _plaka = "81";

            //* Araç km bilgisini tutan bir değişken
            int km = 100000;

            //* Müşteri id'sini tutacak bir değişken
            string musteriId = "A12313131";


            //* Bir ürünün satışta olup olmadığı bilgisini tutacak değişken
            bool satistami = true;
            bool _satistami = false;


            //* Maaş bilgisini tutacak bir değişken (float,double,decimal)
            decimal maas = 3000.13213m;


            //* Öğrenci adını ve soyadını tutacak bir değişken
            string ad = "Sadık";
            string soyad = "Turan";
            string fullname = ad + " " + soyad;   // Abdullah Akyol

            string adsoyad = "Abdullah Akyol";


            //* Şube kodunu tutacak bir değişken (örneğin ; A)  
            char sube = 'A';
            string _sube = "10A";

        }
        public static void TurDonusumu()
        {
            // implicit casting (automatically): smaller type to larger 
            // int-long-float-double

            int a = 10;
            long b = a;

            float e = 10.5f;
            double f = e;

            // explicit casting (manually): larger type to smaller
            long c = 10;
            int d = (int)c;

            double g = 10.6;
            float h = (float)g;

            double k = 10.5;
            int l = (int)k;

            int m = 23654;
            byte n = (byte)m;

            // int to string
            int x = 10;
            string z = x.ToString();

            Console.WriteLine(n);

            // Console.Write("1.sayı: ");
            // int sayi1 = int.Parse(Console.ReadLine());

            // Console.Write("2.sayı: ");
            // int sayi2 = int.Parse(Console.ReadLine());

            // int toplam = sayi1 + sayi2;
            // Console.WriteLine($"girilen toplam değer: {toplam}");
            // Kısa ve uzun kenarı girilen dikdörtgenin alan ve çevresini hesaplayınız. 

            Console.Write("kısa kenar: ");
            int kisa = int.Parse(Console.ReadLine());

            Console.Write("uzun kenar: ");
            int uzun = int.Parse(Console.ReadLine());

            var alan = kisa * uzun;
            var cevre = (kisa + uzun) * 2;

            // var str = "Abdullah Akyol";
            // var price = 100.5;

            // Console.WriteLine("alan: "+ alan + " çevre: "+ cevre);
            Console.WriteLine($"alan: {alan} çevre: {cevre}");
        }
    }
}
