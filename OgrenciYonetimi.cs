using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Yonetim_Sistemi
{
   
    internal class OgrenciYonetimi
    {
       static List<string> ogrencilistesi = new List<string> { "Ali Kaptan", "Ahmet Yıldız", "Ayşegül Soner", "Nazlı Çıkaran", "Ebrar Kara", "Deniz Yurtseven", "Kemal Günçıktı", };

       

       static List<int> ogrenciyaslari = new List<int> { 18, 20, 17, 21, 18, 20, 22 };

        internal static void OgrenciYonetimiPaneli()
        {
            string secim = "";
            while(true)
            {
                Console.WriteLine("1-Öğrenci Ekleme");
                Console.WriteLine("2-Öğrenci Bilgilerini Güncelleme");
                Console.WriteLine("3-Öğrenci silme");
                Console.WriteLine("4-Tüm Öğrencileri Listeleme");
                Console.WriteLine("Bir Seçim Yapınız(1/2/3/4):");
                secim = Console.ReadLine();

                if (secim == "1")
                {
                    OgrenciEkleme();
                }
                else if (secim == "2")
                {
                    OgrenciBilgileriniGüncelle();
                }
                else if (secim == "3")
                {
                    OgrenciSilme();
                }
                else if (secim == "4")
                {
                    TumOgrencileriList();
                }
                else
                {
                    Console.WriteLine("Geçerli Bir Tuşlama Yapınız!!!");
                }
            }

        }
       
        internal static void OgrenciEkleme()
        {
            Console.WriteLine("Eklenecek Öğrencinin Adını-Soyadını ve Yaşını Alt Alta Giriniz!");
            string eklenecekisim = Console.ReadLine();
            int eklenecekyas = Convert.ToInt32(Console.ReadLine());
         
            if (!ogrencilistesi.Contains(eklenecekisim))
            {              
                ogrencilistesi.Add(eklenecekisim);              
                ogrenciyaslari.Add(eklenecekyas);

                Console.WriteLine($"Eklenen Öğrencinin Adı-Soyadı :{eklenecekisim} - Yaşı:{eklenecekyas} ");
            }
            else
            {
                Console.WriteLine("Bu Öğrenci Zaten Mevcut!!!");
            }

        }
        internal static void OgrenciBilgileriniGüncelle()
        {
            Console.WriteLine("Güncellemek İstediğiniz Öğrencinin Adını-Soyadını ve Yaşını Alt Alta Yazınız!");

            string guncellenecekkisi = Console.ReadLine();
            int guncellenecekyas = Convert.ToInt32(Console.ReadLine());
            
            if (ogrencilistesi.Contains(guncellenecekkisi))
            {
                int index = ogrencilistesi.IndexOf(guncellenecekkisi);          
                ogrenciyaslari[index] = guncellenecekyas;

                Console.WriteLine($"Güncellenen Kişinin Adı-Soyadı:{guncellenecekkisi} - Yaşı{guncellenecekyas}");

            }
            else
            {
                Console.WriteLine("Bu Öğrenci Mevcut Değil!!!");
            }
        }
        internal static void OgrenciSilme()
        {
            Console.WriteLine("Silmek İstediğiniz Öğrencinin Adını-Soyadını ve Yaşını Alt Alta Yazınız!");

            string silinecekkisi = Console.ReadLine();
            int silinecekyas = Convert.ToInt32(Console.ReadLine());
           
            if (ogrencilistesi.Contains(silinecekkisi))
            {              
                ogrencilistesi.Remove(silinecekkisi);              
                ogrenciyaslari.Remove(silinecekyas);

                Console.WriteLine($"Silinecek Kişinin Adı-Soyadı:{silinecekkisi} - Yaşı{silinecekyas} ");

            }
            else
            {
                Console.WriteLine("Bu Öğrenci Zaten Mevcut Değil!!!");
            }
        }
        internal static void TumOgrencileriList()
        {


            for (int i = 0; i < ogrencilistesi.Count; i++)
            {
                Console.WriteLine($"Öğrenci:{ogrencilistesi[i]} - Yaş:{ogrenciyaslari[i]}\n");
            }

        }

    }
    
}
