using System;
using System.Collections.Generic;
using System.Text;

namespace GameConceptInterfaceDemo
{
    class Kampanya1 : IKampanyaManager
    {
        
        public void KampanyaEkle()
        {
            Console.WriteLine("Kampanya1 sisteme başarıyla eklendi!");
            
        }

        public void KampanyaGuncelle()
        {
            Console.WriteLine("Kampanya1 başarıyla güncellendi!");
        }

        public void KampanyaSil()
        {
            Console.WriteLine("Kampanya1 sistemden silindi!");
        }
    }
}
