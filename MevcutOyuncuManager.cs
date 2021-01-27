using System;
using System.Collections.Generic;
using System.Text;

namespace GameConceptInterfaceDemo
{
    class MevcutOyuncuManager : IOyuncuManager
    {
        public void HesapIslemi(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " Hesabınız başarıyla silinmiştir.");
        }

        public void HesapGuncelle_Sorgula(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " Hesabınız başarıyla güncellenmiştir.");
        }
    }
}
