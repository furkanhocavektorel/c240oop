
namespace OOP
{
    internal class OgretmenIsleri
    {

        public bool ogrenciEkle(String ad, String soyad, int yas)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = ad;
            ogrenci.soyad = soyad;
            ogrenci.yas = yas;
            if (ogrenci.yas<18)
            {
                return false;
            }
            
            DataBase db = new DataBase();
            db.ogrenciEkle(ogrenci);
            return true;

        }

        public void ogrencileriEkranaBastır()
        {
            
            foreach (Ogrenci ogrenciiii in DataBase.c240DBsi)
            {
                Console.WriteLine(ogrenciiii.ad + " , " + ogrenciiii.soyad +
                    " , " + ogrenciiii.yas);
            }

        }




    }
}
