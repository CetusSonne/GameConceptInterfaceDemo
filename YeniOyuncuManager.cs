using System;
using System.Collections.Generic;
using System.Text;

namespace GameConceptInterfaceDemo
{
    class YeniOyuncuManager : IOyuncuManager
    {
        public void HesapIslemi(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " Hesabınız başarıyla oluşturuldu. Kimlik doğrulaması yapmayı unutmayın!");
        }

        public void HesapGuncelle_Sorgula(Oyuncu oyuncu)
        {
            Console.WriteLine(oyuncu.Ad + " Hesabınız başarıyla sorgulanmıştır.");
            //Bence saçma oldu bu.
        }
    }
}
