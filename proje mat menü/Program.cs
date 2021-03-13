using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_mat_menü
{
    class Program
    {
        static void Main(string[] args)
        {
            int islem;
            Console.WriteLine("Matematik menüsüne hoşgeldiniz...");
            Console.WriteLine();
            Console.WriteLine("********MENÜ*********");
            Console.WriteLine();
            Console.WriteLine("1-DÖRT İŞLEM");
            Console.WriteLine("2-ÜS ALMA");
            Console.WriteLine("3-KÖK ALMA");
            Console.WriteLine("4-KARENİN ÇEVRESİNİ VE ALANINI HESAPLAMA");
            Console.WriteLine("5-DİKDÖRTGENİN ÇEVRESİNİ VE ALANINI HESAPLAMA");
            Console.WriteLine("6-EŞKENAR ÜÇGENİN ÇEVRESİNİ HESAPLAMA");
            Console.WriteLine();
            islem = Convert.ToInt16(Console.ReadLine());
            if (islem==1)
            {
                int a, b, toplama, cıkarma, carpma, bolme;
                Console.WriteLine("1.sayıyı giriniz.");
                 a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.sayıyı giriniz.");
                b = Convert.ToInt32(Console.ReadLine());
                toplama = a + b;
                cıkarma = a - b;
                carpma = a * b;
                bolme = a / b;
                Console.WriteLine("TOPLAMA: "+toplama);
                Console.WriteLine("ÇIKARMA: "+cıkarma);
                Console.WriteLine("ÇARPMA: "+carpma);
                Console.WriteLine("BÖLME: "+bolme);
                                            
            }
            if (islem==2)
            {
                double sayi, us, sonuc;
                Console.WriteLine("sayıyı giriniz.");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("üssü giriniz.");
                us = Convert.ToDouble(Console.ReadLine());
                sonuc = Math.Pow(sayi, us);
                Console.WriteLine("SONUÇ: "+sonuc);
                
            }
            if (islem==3)
            {
                double kok, sonuc2;
                Console.WriteLine("kökü alınacak sayıyı giriniz.");
                kok = Convert.ToDouble(Console.ReadLine());
                sonuc2 = Math.Sqrt(kok);
                Console.WriteLine("SONUÇ: "+sonuc2);
            }
            if (islem==4)
            {
                int kenar,Kalan,Kcevre;
                Console.WriteLine("karenin bir kenarını giriniz.");
                kenar = Convert.ToInt32(Console.ReadLine());
                Kalan = kenar * kenar;
                Kcevre = kenar * 4;
                Console.WriteLine("KARENİN ALANI: "+Kalan);
                Console.WriteLine("KARENİN ÇEVRESİ: "+Kcevre);
            }
            if (islem==5)
            {
                int ukenar, kkenar, dalan, dcevre;
                Console.WriteLine("dikdörtgenin uzun kenarını giriniz.");
                ukenar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dikdörtgenin kısa kenarını giriniz");
                kkenar = Convert.ToInt32(Console.ReadLine());
                dalan = kkenar * ukenar;
                dcevre = (kkenar + ukenar) * 2;
                Console.WriteLine("DİKDÖRTEGENİN ALAN: "+dalan);
                Console.WriteLine("DİKDÖRTGENİN ÇEVRESİ: "+dcevre);
            }
            if (islem==6)
            {
                int uckenar,sonuc;
                Console.WriteLine("eşkenar üçgeinin kenarını giriniz.");
                uckenar = Convert.ToInt32(Console.ReadLine());
                sonuc = uckenar * 3;
                Console.WriteLine("EŞKENAR ÜÇGENİN ÇEVRESİ: "+sonuc);
            }
            Console.ReadLine();
        }
    }
}
