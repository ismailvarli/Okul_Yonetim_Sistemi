using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Yonetim_Sistemi
{
    internal class SinifveDersYonetimi
    {
        static List<string> dersler = new List<string> { "Felsefe", "Matematik", "Tarih", "Fizik", "Resim" };
        static List<string> siniflar = new List<string> {"Nazım Hikmet Sınıfı", "Tevfik Fikret Sınıfı", "Nihal Atsız SInıfı", "Kemal Tahir Sınıfı"};

        static List<List<string>> sinifOgrencileri = new List<List<string>>
    {
        new List<string>(),//Nazım Hikmet Sınıfı
        new List<string>(),//Tevfik Fikret Sınıfı
        new List<string>(),//Nihal Atsız SInıfı
        new List<string>(),//Kemal Tahir Sınıfı
    };

        internal static void SinifveDersYonetimiPaneli()
        {
            {
                Console.WriteLine("1-Sınıf ve Ders Ekleme");
                Console.WriteLine("2-Sınıfa Öğrenci Ekleme");
                Console.WriteLine("3-Sınıf ve Ders Bilgilerini GÜncelleme");
                Console.WriteLine("4-Tüm Sınıfları ve Dersleri Listeleme");
                Console.WriteLine("Bir Seçim Yapınız(1/2/3/4):");

                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    SinifveDersEkleme();
                }
                else if (secim == "2")
                {
                    SinifaOgrenciEkleme();
                }
                else if (secim == "3")
                {
                    SinifveDersBilgileriniGuncelleme();
                }
                else if (secim == "4")
                {
                    TumSınıfveDersList();
                }
                else
                {
                    Console.WriteLine("Geçerli Bir Tuşlama Yapınız!!!");
                }
            }
        }
        internal static void SinifveDersEkleme()
        {
            Console.WriteLine("1-Ders Ekle\n2-Sınıf Ekle");
            Console.WriteLine("Bir Seçim Yapınız(1/2)");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Eklenecek Dersin Adını Giriniz!");
                string eklenecekders = Console.ReadLine();
                if (!dersler.Contains(eklenecekders))
                {
                    dersler.Add(eklenecekders);
                    Console.WriteLine($"Eklenen Ders:{eklenecekders}");
                }

            }
            else if (secim == "2")
            {
                Console.WriteLine("Eklenecek Sınıfın Adını Giriniz!");
                string ekleneceksinif = Console.ReadLine();
                if (!dersler.Contains(ekleneceksinif))
                {
                    siniflar.Add(ekleneceksinif);
                    Console.WriteLine($"Eklenen Sınıf:{ekleneceksinif}");
                }
            }
            else
            {
                Console.WriteLine("Geçerli Bir Tuşlama Yapınız!!!");
            }
        }
        internal static void SinifaOgrenciEkleme()
        {
            Console.WriteLine("Hangi Sınıfa Öğrenci Eklemek İstiyorsunuz?");
            string secilensinif = Console.ReadLine();
           
            int index = siniflar.IndexOf(secilensinif);
     
            if (index != -1)
            {       
                Console.WriteLine("Eklemek İstediğiniz Öğrencinin Adını Yazınız:");
                string eklenecekogrenci = Console.ReadLine(); 
                
                sinifOgrencileri[index].Add(eklenecekogrenci);
                
                Console.WriteLine($"{eklenecekogrenci} {secilensinif}'na eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Böyle bir sınıf bulunamadı!");
            }

        }
        internal static void SinifveDersBilgileriniGuncelleme()
        {
            Console.WriteLine("1-Ders Güncelle\n2-Sınıf Güncelle");
            Console.WriteLine("Bir Seçim Yapınız(1/2)");

            string secim = Console.ReadLine();

            if(secim=="1")
            {
                Console.WriteLine("Güncellenecek Dersin Adını Giriniz!");
                string guncellenecekders = Console.ReadLine();
                if (dersler.Contains(guncellenecekders))
                {
                    int index = dersler.IndexOf(guncellenecekders);
                    dersler[index] = guncellenecekders;
                    Console.WriteLine($"Güncellenen Ders:{guncellenecekders}");
                }
                    
            }
           else if (secim == "2")
            {
                Console.WriteLine("Güncellenecek Sınıfın Adını Giriniz!");
                string guncelleneceksinif = Console.ReadLine();
                if (dersler.Contains(guncelleneceksinif))
                {
                    int index = dersler.IndexOf(guncelleneceksinif);
                    dersler[index] = guncelleneceksinif;
                    Console.WriteLine($"Güncellenen Sınıf:{guncelleneceksinif}");
                }
            }
            else
            {
                Console.WriteLine("Geçerli Bir Tuşlama Yapınız!!!");
            }

        }
        internal static void TumSınıfveDersList()
        {
         
            for (int i = 0; i < dersler.Count; i++)
            {
                Console.WriteLine($"Ders:{dersler[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < siniflar.Count; i++)
            {
                Console.WriteLine($"Sınıf:{siniflar[i]}");
            }
            Console.WriteLine();
        }
    }
}
