using System;
using System.Collections.Generic;
using System.Text;

namespace GameConceptInterfaceDemo
{
    class Oyun1 : ISatisManager
    {
        public void SatinAl(Oyuncu oyuncu, IKampanyaManager kampanya)
        {
            Console.WriteLine("Sayın "+ oyuncu.Ad + " 'Oyun1' satın alımınız 10.00$'a başarıyla gerçekleşti!.");
            //Entegrasyonu başaramadım...
        }
    }
}
