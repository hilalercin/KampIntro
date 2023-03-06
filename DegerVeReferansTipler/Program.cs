namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1? 30

            int[] sayilar1 = new int[] {10, 20, 30};
            int[] sayilar2 = new int[] {100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]? 999


            /*
            sayısal veri tipleri (int, decimal, float, double, bool) değer tiplerdir. Array, class, interface ise
            referans tiplerdir. Bellekte stack ve heap diye iki alan vardır. Bir değişken tanımladığımızda değer tip
            olanlar stackte gerçekleşiyor. sayi1'in değeri eşittir 10 şeklinde okunur. sayi1 eşittir sayi2 kısmında
            sadece değer (30) aktarılır ve sayi2 ile olan irtibat kopar. sayi2 eşittir 65 kısmında da sayi2'nin değeri
            65 yapılır, sayi1 ile hiçbir alakası yoktur. Olay sadece değeri atamak olduğu için cevap 30 olur.
            int[] sayilar1 diye bir değişken tanımlandığında stackte olur. new dediğimiz anda sayilar1 için heapte 
            yeni bir alan oluşturulur ve değerler ({10, 20, 30}) oraya yazılır. Mesela sayilar1 101 diye bir adreste
            tutulsun. sayilar2 de 102 diye bir adreste tutulsun. Daha sonra 15.satır sayilar1'in referans numarası,
            sayilar2'nin referans numarasına eşittir diye okunmalıdır. Yani sayilar2'nin referans numarası olan 102,
            sayilar1'e atanmış oldu. Daha sonra sayilar2'nin 0.elemanı 999 olarak atanır. ({999, 200, 300})
            sayilar1'in 0.elemanı da 999 olmuş olur. Çünkü sayilar1, 102'yi tutuyor. Stackte 101'i tutan kimse
            kalmadığı için de garbage collector ile bellekten atılır.
            */  

        }
    }
}