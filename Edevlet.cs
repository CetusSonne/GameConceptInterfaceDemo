using System;
using System.Collections.Generic;
using System.Text;

namespace GameConceptInterfaceDemo
{
    class Edevlet
    {
        //Üşendiğim için sadece tckn ile "if" yapısını kullandım.
        public void Dogrulama(YeniOyuncu yeniOyuncu, TCKK kisi)
        {
            if(yeniOyuncu.TCKN == kisi.TCKN)
            {
                Console.WriteLine("Hesabınız başarıyla doğrulandı!");
            }
            else
            {
                Console.WriteLine("Hesap bilgileriniz kimliğiniz ile uyumlu değil!");
            }

        }
    }
}
