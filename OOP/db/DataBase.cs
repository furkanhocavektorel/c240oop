
namespace OOP
{
    internal class DataBase
    {
        public static List<Ogrenci> c240DBsi = new List<Ogrenci>();

        public void ogrenciEkle(Ogrenci ogr)
        {
            c240DBsi.Add(ogr);
        }

        public List<Ogrenci> ogrenciListesi()
        {
            return c240DBsi;    
        }

    }
}
