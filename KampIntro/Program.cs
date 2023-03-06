using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //do not repeat yourself
            //değer tutucu

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 17.40;
            double dolarBugun = 17.40;

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if ((dolarDun > dolarBugun))
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

             

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
                





            Console.WriteLine(kategoriEtiketi);
         
            
            
            
            
            
            Console.ReadKey();

        }
    }
}
