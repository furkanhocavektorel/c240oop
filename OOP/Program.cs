
using OOP.controller;

namespace OOP
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            int dongu = 1;
            while (dongu!=0)
            {
                Console.WriteLine("adinizi giriniz...");
                String ad= Console.ReadLine();

                Console.WriteLine("soyadinizi giriniz...");
                String soyad= Console.ReadLine();
            
                Console.WriteLine("yasinizi girinizi...");
                int yas = Convert.ToInt32(Console.ReadLine());
                
                OgretmenController ogretmenController  =new OgretmenController();
            
                bool kayitAtildiMi=ogretmenController.ogrenciEklemeMetodu(ad, soyad, yas);

                if (kayitAtildiMi)
                {
                    Console.WriteLine("kayit basarili");
                    dongu = 0;
                }
                else
                {
                    Console.WriteLine("kayit basarisiz yas 18 den kücük olamaz");
                }


            }
            
            
        }









    }
}