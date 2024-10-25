namespace OOP.controller;

public class OgretmenController
{
    public bool ogrenciEklemeMetodu(string ad, string soyad, int yas)
    {
        OgretmenIsleri ogretmenIsleri = new OgretmenIsleri();
        return ogretmenIsleri.ogrenciEkle(ad,soyad,yas);
    }
}