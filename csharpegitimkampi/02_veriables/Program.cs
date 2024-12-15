using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Veriables (double)

            //double appleprice, orangeprice, strawberryprice, potatoprice, tomatoprice;

            //appleprice = 10;
            //orangeprice = 20;
            //strawberryprice = 22.5;
            //potatoprice = 13.25;
            //tomatoprice = 9.45;

            //Console.WriteLine("***** Manav Fiyat Listesi *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Elma'nın kilosu: " + appleprice + " Tl");
            //Console.WriteLine("Portakal'ın kilosu: " + orangeprice + " Tl");
            //Console.WriteLine("Çilek'in kilosu: " + strawberryprice + " Tl");
            //Console.WriteLine("Patates'in kilosu: " + potatoprice + " Tl");
            //Console.WriteLine("Domates'in kilosu: " + tomatoprice + " Tl");
            //Console.WriteLine("-------------------------------");
            //Console.ReadLine();

            //double SoldApple, SoldOrange, SoldStrawberry, SoldPotato, SoldTomato;
            //SoldApple = 1.25;
            //SoldOrange = 2.15;
            //SoldStrawberry = 1.5;
            //SoldPotato = 2.6;
            //SoldTomato = 3;

            //double TotalPriceApple, TotalPriceOrange, TotalPriceStrawberry, TotalPricePotato, TotalPriceTomato;
            //TotalPriceApple = appleprice * SoldApple;
            //TotalPriceOrange = orangeprice * SoldOrange;
            //TotalPriceStrawberry= strawberryprice * SoldStrawberry;
            //TotalPricePotato=potatoprice * SoldPotato;
            //TotalPriceTomato=tomatoprice * SoldTomato;
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("******** Sales Receipt ********");
            //Console.WriteLine();
            //Console.WriteLine(SoldApple + "  kg Elma       " + TotalPriceApple + "   Tl");
            //Console.WriteLine(SoldOrange + "  kg Portakal   " + TotalPriceOrange + "     Tl");
            //Console.WriteLine(SoldStrawberry + "   kg Çilek      " + TotalPriceStrawberry + "  Tl");
            //Console.WriteLine(SoldTomato + "     kg Patates    " + TotalPricePotato + "  Tl");
            //Console.WriteLine(SoldPotato + "   kg Domates    " + TotalPriceTomato + "  Tl");
            //Console.WriteLine() ;

            //double TotalPrice= TotalPriceApple+TotalPriceOrange+TotalPriceStrawberry+TotalPricePotato+TotalPriceTomato;

            //Console.WriteLine("Toplam Tutar:       " + TotalPrice + " Tl");
            //Console.WriteLine("-------------------------------");

            #endregion

            #region Veriables (char)

            //char symbol;
            //symbol = 'x';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden string veri Girisi 

            //string passengerName, passengerSurname, passengerIdentityNumber, passengerAge, city, distinc;

            //Console.Write("Yolcu adı: ");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname=Console.ReadLine();

            //Console.Write("Yolcu TC'si: ");
            //passengerIdentityNumber=Console.ReadLine();

            //Console.Write("Yolcu yaşı: ");
            //passengerAge=Console.ReadLine();

            //Console.Write("Gideceği Şehir: ");
            //city=Console.ReadLine();

            //Console.Write("Gideceği ilçe: ");
            //distinc=Console.ReadLine();
            //Console.WriteLine("---------------------------------------");

            //Console.WriteLine(passengerIdentityNumber + " - " + passengerName + " " + passengerSurname + " - (" + passengerAge + ") - " + city + " / " + distinc);
            //Console.WriteLine("---------------------------------------");

            #endregion

            #region klavyeden int veri girisi 

            //int tvPrice, shoesPrice, computerPrice, chairPrice;

            //tvPrice = 3000;
            //shoesPrice = 650;
            //computerPrice = 6000;
            //chairPrice = 2000;

            //Console.WriteLine("********** Çiçek Mağaza **********");
            //Console.WriteLine("----------------------------------");
            //Console.ReadLine();
            //Console.WriteLine("Bilgisayar Fiyatı: "+computerPrice);
            //Console.WriteLine("Sandalye Fiyatı: "+chairPrice);
            //Console.WriteLine("Ayakkabı Fiyatı: "+shoesPrice);
            //Console.WriteLine("Televizyon Fiyatı: "+tvPrice);
            //Console.WriteLine("----------------------------------");

            //int soldTv, soldComputer, soldChair, soldShoes;

            //Console.Write("Kaç adet Bilgisayar istersiniz?: ");
            //soldComputer=int.Parse(Console.ReadLine());

            //Console.Write("Kaç adet Sandalye istersiniz?: ");
            //soldChair=int.Parse(Console.ReadLine());

            //Console.Write("Kaç adet Ayakkabı istersiniz?: ");
            //soldShoes=int.Parse(Console.ReadLine());

            //Console.Write("Kaç adet Televizyon istersiniz?: ");
            //soldTv=int.Parse(Console.ReadLine());

            //Console.WriteLine("----------------------------------");


            //int totalPriceTv=tvPrice*soldTv;
            //int totalPriceComputer=computerPrice*soldComputer;
            //int totalPriceChair=chairPrice*soldChair;
            //int totalPriceShoes = shoesPrice * soldShoes;

            //int totalPrice = totalPriceTv + totalPriceChair + totalPriceComputer + totalPriceShoes;

            //Console.WriteLine(soldComputer+"x Bilgisayar  "+totalPriceComputer+" tl");
            //Console.WriteLine(soldChair+"x Sandalye  "+totalPriceChair+" tl");
            //Console.WriteLine(soldShoes+"x Ayakkabı  "+totalPriceShoes+" tl");
            //Console.WriteLine(soldTv+"x Televizyon  "+totalPriceTv+" tl");
            //Console.WriteLine("");
            //Console.WriteLine("Toplam Tutar: " + totalPrice);

            #endregion

            #region klavyeden double veri girisi 

            //double exam1,exam2,exam3,result;

            //Console.Write("1.sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("1.sınav notunu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("1.sınav notunu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Dönem ortalamanız: "+result);

            #endregion

            #region klavyeden char veri girisi

            char gender;

            Console.Write("lütfen cinsiyetiniz erkekse e, kadınsa k olarak giriniz:");
            gender =char.Parse(Console.ReadLine());

            Console.Write("cinsiyetiniz " + gender);

            #endregion

            Console.ReadLine();
        }
    }
}
