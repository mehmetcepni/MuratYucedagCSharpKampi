using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_C_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDEgiskenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("--- Elma Birim Fiyatı:"+applePrice +" TL");
            //Console.WriteLine("--- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("--- Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("--- Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("--- Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice= orangeGram * orangePrice;
            //double strawberryTotalPrice=strawberryGram * strawberryPrice;
            //double potatoTotalPrice=potatoGram*potatoPrice;
            //double tomatoTotalPrice=tomatoGram*tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma      - Birim Fiyat:"+applePrice+" -Gramaj:"+appleGram+" --Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal  - Birim Fiyat:" + orangePrice + " -Gramaj:" + orangeGram + "  --Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek     - Birim Fiyat:" + strawberryPrice + "    -Gramaj:" + strawberryGram + "  --Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates   - Birim Fiyat:" + potatoPrice + "  -Gramaj:" + potatoGram + " --Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates   - Birim Fiyat:" + tomatoPrice + "  -Gramaj:" + tomatoGram + " --Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: "+shoppingTotalPrice+" TL");

            #endregion

            #region CharDegiskenler

            //char symbol;
            //symbol='A';
            //Console.WriteLine(symbol);

            #endregion

            #region KlavyedenVeriGirişleriStringİslemleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge,passangerIdentityNumber;
            //Console.Write("Yolcu Adı:");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passangerSurname = Console.ReadLine();


            //Console.Write("İlçe Bilgisi:");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi:");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş:");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu TC kimlik no:");
            //passangerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Yolcu: "+passangerName+" "+passangerSurname+" "+passangerDistrict+" "+passangerCity+" "+passangerAge+" "+passangerIdentityNumber);
            #endregion

            #region KlavyedenTamSayıGirisleriveDÖnüsümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice=shoesCount*shoesPrice + computerCount*computerPrice +chairCount*chairPrice + tvCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Ödemeniz Gereken Tutar: "+totalPrice);

            #endregion

            #region KlavyedenOndalıklıSayıİşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1.Sınav Notunu Giriniz:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.Sınav Notunu Giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3.Sınav Notunu Giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result=(exam1+exam2+ exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);



            #endregion

            #region KlavyedenKarakterGirişleri

            //char gender;
            //Console.WriteLine("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : "+ gender);
            #endregion
            Console.ReadLine();
        }
    }
}
