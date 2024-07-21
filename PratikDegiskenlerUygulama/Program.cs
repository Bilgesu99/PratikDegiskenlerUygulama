// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;
namespace PratikUygulama
{
    class program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Lütfen Aşağıdaki Bilgileri Giriniz:");

            Console.Write("T.C. Kimlik Numarası:");
            string TC = Console.ReadLine();

             Console.Write("Adi:");
            string name = Console.ReadLine();

            Console.Write("Soyadi:");
            string surname = Console.ReadLine();

            Console.Write("Telefon Numarasi:");
            string Tel = Console.ReadLine();  //Telefon numarası ile ileride matematiksel bir işlem yapılmayacağından string olarak kullandım. 

            Console.Write("Yas:");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ilk Alınan Urun Fiyati:");
            double BirinciUrun = Convert.ToInt32(Console.ReadLine()); //İleriki aşamada ürün fiyatlarının toplanmasını isteyeceğimden sayısal veri olarak almam gerekiyordu. Ürün fiyatının ondalıklı da olabileceğini düşünerek "double" kullandım.

            Console.Write("Ikınci Alınan Urun Fiyati:");
            Double IkinciUrun = Convert.ToInt32(Console.ReadLine()); //

            Double Toplam = BirinciUrun + IkinciUrun;

            Console.WriteLine(TC + "numaralı" + name + surname +  "isimli kişi sisteme kaydedilmiştir.");
            Console.WriteLine(Tel + "Telefon numarasına bildirim mesajı gönderilmiştir");
            Console.WriteLine(Toplam + "karşılığı olarak" + ((IkinciUrun + BirinciUrun) / 10) + "Bilgos puanı kazanılmıştır."); 


            


        
        
        
        }
    }
}