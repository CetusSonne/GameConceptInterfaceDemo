using System;

namespace GameConceptInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------Kişi Bilgileri---------------------------------------\\
            YeniOyuncu yenioyuncu1 = new YeniOyuncu();
            yenioyuncu1.TCKN = "14444444444444";
            yenioyuncu1.Ad = "Bora";
            yenioyuncu1.Soyad = "Kıroğlu";
            yenioyuncu1.Id = 2;
            yenioyuncu1.TutorialDurumu = false;
            
            MevcutOyuncu mevcutoyuncu1 = new MevcutOyuncu();
            mevcutoyuncu1.Id = 1;
            mevcutoyuncu1.TCKN = "33333333333";
            mevcutoyuncu1.Ad = "Uğur";
            mevcutoyuncu1.Soyad = "Kıroğlu";
            mevcutoyuncu1.Seviye = 27;
            mevcutoyuncu1.KdA = 2.87;

            TCKK birey1 = new TCKK();
            birey1.TCKN = "244444444444";
            birey1.Ad = "Bora";
            birey1.Soyad = "Kıroğlu";
            //-----------------------------------------------------------------------------------------\\
            //----------------------------------------Simülasyon----------------------------------------\\
            IOyuncuManager yenioyuncuManager = new YeniOyuncuManager();
            IOyuncuManager mevcutoyuncuManager = new MevcutOyuncuManager();

            yenioyuncuManager.HesapIslemi(yenioyuncu1);
            mevcutoyuncuManager.HesapIslemi(mevcutoyuncu1);

            yenioyuncuManager.HesapGuncelle_Sorgula(yenioyuncu1);
            mevcutoyuncuManager.HesapGuncelle_Sorgula(mevcutoyuncu1);

            Edevlet edevlet = new Edevlet();
            edevlet.Dogrulama(yenioyuncu1, birey1);

            ISatisManager satisManager = new Oyun1();
            IKampanyaManager kampanyaDefault = new KampanyaDefault();
            satisManager.SatinAl(mevcutoyuncu1,kampanyaDefault);

            IKampanyaManager kampanyaManager = new Kampanya1();
            kampanyaManager.KampanyaEkle();
            kampanyaManager.KampanyaGuncelle();
            kampanyaManager.KampanyaSil();

            //--------------------------------------------------------------------------------------------\\
        }
    }
}
