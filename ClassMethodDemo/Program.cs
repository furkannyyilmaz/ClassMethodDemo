using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri1 = new Customer();

            musteri1.MusteriId = 301;
            musteri1.MusteriAdi = "Furkan";
            musteri1.MusteriSoyadi = "Yılmaz";
            musteri1.MusteriTelNo = 910203;

            Customer musteri2 = new Customer();
            
            musteri2.MusteriId = 302;
            musteri2.MusteriAdi = "Atakan Buğra";
            musteri2.MusteriSoyadi = "Yılmaz";
            musteri2.MusteriTelNo = 910204;

            Customer musteri3 = new Customer();

            musteri3.MusteriId = 303;
            musteri3.MusteriAdi = " Buğra";
            musteri3.MusteriSoyadi = "Yılmaz";
            musteri3.MusteriTelNo = 910204;

            Customer[] musteriler = new Customer[] { musteri1, musteri2, musteri3};

            foreach (Customer musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi+" "+ musteri.MusteriSoyadi);
               
            }
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(313,"deAndre","yedlin",31 );

            customerManager.Ekle(334, "gedson","fernandes",12);

           

        }
    }
}
