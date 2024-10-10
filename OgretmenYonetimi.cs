using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Yonetim_Sistemi
{
    internal class OgretmenYonetimi
    {
        static List<string> OgretmenListesi = new List<string> { "Gizem Çetinok", "İsmail Yıldız", "Taner Kırhan", "Sedat Çelebisoy", "Özgür Arslan" };

        static List<string> Ogretmendersleri = new List<string> {"Felsefe","Matematik","Tarih","Fizik","Resim" };

        static List<int> OgretmenYasi = new List<int> { 30,51,55,42,26};

        internal static void OgretmenYonetimiPaneli()
        {
            string secim = "";
            while (true)
            {
                Console.WriteLine("1-Öğretmen Ekleme");
                Console.WriteLine("2-Öğretmen Bilgilerini Güncelleme");
                Console.WriteLine("3-Öğretmen silme");
                Console.WriteLine("4-Tüm Öğretmenleri Listeleme");
                Console.WriteLine("Bir Seçim Yapınız(1/2/3/4):");
                secim = Console.ReadLine();

                if (secim == "1")
                {
                    OgretmenEkleme();
                }
                else if (secim == "2")
                {
                   OgretmenBilgileriniGüncelle();
                }
                else if (secim == "3")
                {
                    OgretmenSilme();
                }
                else if (secim == "4")
                {
                    TumOgretmenleriList();
                }
                else
                {
                    Console.WriteLine("Geçerli Bir Tuşlama Yapınız!!!");
                }
            }

        }

        internal static void OgretmenEkleme()
        {
            Console.WriteLine("Eklenecek Öğretmenin Adını-Soyadını, Yaşını ve Dersini Alt Alta Giriniz!");
            string eklenecekisim = Console.ReadLine();
            int eklenecekyas = Convert.ToInt32(Console.ReadLine());
            string eklenecekdersler = Console.ReadLine();

            if (!OgretmenListesi.Contains(eklenecekisim))
            {
                
                OgretmenListesi.Add(eklenecekisim);
                Ogretmendersleri.Add(eklenecekdersler);
                OgretmenYasi.Add(eklenecekyas);
                Console.WriteLine($"Eklenen Öğretmenin Adı-Soyadı :{eklenecekisim} - Yaşı:{eklenecekyas} - Dersi:{eklenecekdersler}");
            }
            else
            {
                Console.WriteLine("Bu Öğretmen Zaten Mevcut!!!");
            }

        }
        internal static void OgretmenBilgileriniGüncelle()
        {
            Console.WriteLine("Güncellemek İstediğiniz ÖĞretmenın Adını-Soyadını, Yaşını ve Dersini Alt Alta Yazınız!");
            string guncellenecekkisi = Console.ReadLine();
            int guncellenecekyas = Convert.ToInt32(Console.ReadLine());
            string guncellenecekders  = Console.ReadLine();
            if (OgretmenListesi.Contains(guncellenecekkisi))
            {
                int index = OgretmenListesi.IndexOf(guncellenecekkisi);
                OgretmenYasi[index] = guncellenecekyas;
                Ogretmendersleri[index] = guncellenecekders;

                Console.WriteLine($"Güncellenen Kişinin Adı-Soyadı:{guncellenecekkisi} - Yaşı{guncellenecekyas} - Dersi:{guncellenecekders}");

            }
            else
            {
                Console.WriteLine("Bu Öğretmen Mevcut Değil!!!");
            }
        }
        internal static void OgretmenSilme()
        {
            Console.WriteLine("Silmek İstediğiniz Öğretmenin Adını-Soyadını, Yaşını ve Dersini Alt Alta Yazınız!");
            string silinecekkisi = Console.ReadLine();
            int silinecekyas = Convert.ToInt32(Console.ReadLine());
            string silinecekders = Console.ReadLine();
            if (OgretmenListesi.Contains(silinecekkisi))
            {               
                OgretmenListesi.Remove(silinecekkisi);
                Ogretmendersleri.Remove(silinecekders);
                OgretmenYasi.Remove(silinecekyas);

                Console.WriteLine($"Silinecek Kişinin Adı-Soyadı:{silinecekkisi} - Yaşı{silinecekyas} - Dersi:{silinecekders}");

            }
            else
            {
                Console.WriteLine("Bu Öğretmen Zaten Mevcut Değil!!!");
            }
        }
        internal static void TumOgretmenleriList()
        {


            for (int i = 0; i < OgretmenListesi.Count; i++)
            {
                Console.WriteLine($"Öğretmen:{OgretmenListesi[i]} - Yaş:{OgretmenYasi[i]} - Ders:{Ogretmendersleri[i]}\n");
            }

        }

    }
}
