using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Yonetim_Sistemi
{
    internal class NotSistemi
    {
        static List<string> ogrencilistesi = new List<string> { "Ali Kaptan", "Ahmet Yıldız", "Ayşegül Soner", "Nazlı Çıkaran", "Ebrar Kara", "Deniz Yurtseven", "Kemal Günçıktı", };
        static List<int> felsefenotu  = new List<int> {  };
        static List<int> matnotu = new List<int> { };
        static List<int> tarihnotu = new List<int> { };
        static List<int> fiziknotu = new List<int> {  };
        static List<int> resimnotu = new List<int> {  };

        internal static void NotSistemiPaneli()
        {
            Console.WriteLine("1-Öğrencilerin Ders Notlarını Girme");
            Console.WriteLine("2-Öğrencilerin Ders Notlarını Güncelleme");
            Console.WriteLine("3-Öğrencilerin Ders Notlarını Listeleme");
            Console.WriteLine("4-Öğrencilerin Genel Ortalamasını Hesaplama");
            Console.WriteLine("Bir Seçim Yapınız(1/2/3/4):");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                DersNotuGirme();
            }
            else if (secim == "2")
            {
                DersNotuGuncelleme();
            }
            else if (secim == "3")
            {
                DersNotuList();
            }
            else if (secim == "4")
            {
                GenelOrtHesaplama();
            }
            else
            {
                Console.WriteLine("Geçerli Bir Tuşlama Yapınız!!!");
            }
        }
        internal static void DersNotuGirme()
        {
            for (int i = 0; i < ogrencilistesi.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ogrencilistesi[i]}");
            }
            Console.Write("Not Girmek İstediğiniz Öğrencinin Numarasını Seçin: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Felsefe notunu girin: ");
            felsefenotu.Add(int.Parse(Console.ReadLine()));

            Console.Write("Matematik notunu girin: ");
            matnotu.Add(int.Parse(Console.ReadLine()));

            Console.Write("Tarih notunu girin: ");
            tarihnotu.Add(int.Parse(Console.ReadLine()));

            Console.Write("Fizik notunu girin: ");
            fiziknotu.Add(int.Parse(Console.ReadLine()));

            Console.Write("Resim notunu girin: ");
            resimnotu.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Notlar başarıyla kaydedildi.");
        }
        internal static void DersNotuGuncelleme()
        {
            for (int i = 0; i < ogrencilistesi.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ogrencilistesi[i]}");
            }
            Console.Write("Güncellemek istediğiniz öğrencinin numarasını seçin: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Güncellenmek istenen notlar:");

            Console.WriteLine($"Felsefe: {felsefenotu[index]}");
            Console.Write("Yeni Felsefe notunu girin: ");
            felsefenotu[index] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Matematik: {matnotu[index]}");
            Console.Write("Yeni Matematik notunu girin: ");
            matnotu[index] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tarih: {tarihnotu[index]}");
            Console.Write("Yeni Tarih notunu girin: ");
            tarihnotu[index] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fizik: {fiziknotu[index]}");
            Console.Write("Yeni Fizik notunu girin: ");
            fiziknotu[index] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Resim: {resimnotu[index]}");
            Console.Write("Yeni Resim notunu girin: ");
            resimnotu[index] = int.Parse(Console.ReadLine());

            Console.WriteLine("Notlar başarıyla güncellendi.");
        }
        internal static void DersNotuList()
        {
            Console.WriteLine("Öğrenci Notları:");
            for (int i = 0; i < ogrencilistesi.Count; i++)
            {
                Console.WriteLine($"{ogrencilistesi[i]}: Felsefe: {felsefenotu[i]}, Matematik: {matnotu[i]}, Tarih: {tarihnotu[i]}, Fizik: {fiziknotu[i]}, Resim: {resimnotu[i]}");
            }
        }
        internal static void GenelOrtHesaplama()
        {
            for (int i = 0; i < ogrencilistesi.Count; i++)
            {
                double ortalama = (felsefenotu[i] + matnotu[i] + tarihnotu[i] + fiziknotu[i] + resimnotu[i]) / 5.0;
                Console.WriteLine($"{ogrencilistesi[i]}: Genel Ortalama: {ortalama}");
            }
        }

    }
}
