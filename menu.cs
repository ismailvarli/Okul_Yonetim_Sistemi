using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Yonetim_Sistemi
{
    internal class Menu
    {
        internal static void MenuPaneli()
        {
            string secim = "";
            while (true)
            {
               
                Console.WriteLine("1-Öğrenci Yönetimi");
                Console.WriteLine("2-Öğretmen Yönetimi");
                Console.WriteLine("3-Sınıf ve Ders Yönetimi");
                Console.WriteLine("4-Not Sistemi");
                Console.WriteLine("5-Çıkış");
                Console.WriteLine("Bir Seçim Yapınız:(1/2/3/4/5)");
                

                secim = Console.ReadLine();

                if (secim == "1")
                {
                    OgrenciYonetimi.OgrenciYonetimiPaneli();
                   
                }
                else if (secim == "2")
                {
                    OgretmenYonetimi.OgretmenYonetimiPaneli();
                }
                else if (secim == "3")
                {
                    SinifveDersYonetimi.SinifveDersYonetimiPaneli();
                }
                else if (secim == "4")
                {
                    NotSistemi.NotSistemiPaneli();
                }
                else if (secim == "5")
                {
                    Cikis.CikisPaneli();
                }
                else
                {
                   
                    Console.WriteLine("Geçerli Bir Tuşlama yapınız!!!");
                }
                
            }
        }
    }

}

