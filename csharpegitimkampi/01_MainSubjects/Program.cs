using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Yazdırma komutları
            //Console.Write("merhaba dünya");
            //Console.WriteLine("***** Yemek Çeşitleri *****");
            //Console.ReadLine();

            //Console.WriteLine("1. Çorbalar");
            //Console.ReadLine();

            //Console.WriteLine("2. Ara Sıcaklar");
            //Console.ReadLine();

            //Console.WriteLine("3. Ana Yemekler");
            //Console.ReadLine();

            //Console.WriteLine("4. Tatlılar");
            //Console.ReadLine();

            #endregion

            #region Degiskenler (string)

            //string name;
            //name = "şeyhmus";
            //Console.WriteLine(name);
            //Console.ReadLine();

            //string customer_name;
            //string customer_surname;
            //string customer_phone_number, customer_email;
            //string customer_cıty, customer_district;

            //customer_name = "yusuf";
            //customer_surname = "ÇİÇEK";
            //customer_phone_number = "05364346999";
            //customer_email = "yusufcicek0@gmasil.xom";
            //customer_cıty = "Adana";
            //customer_district = "seyhan";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("İsim: " + customer_name + " " + customer_surname);
            //Console.WriteLine("İletişim Bilgileri");
            //Console.WriteLine("Cep Telefonu: " + customer_phone_number);
            //Console.WriteLine("E-mail. "+customer_email);
            //Console.WriteLine("Adres: "+customer_cıty+"/"+customer_district);
            //Console.WriteLine("-----------------------------");
            //Console.ReadLine();

            //customer_name = "Yakup";
            //customer_surname = "ÇİÇEK";
            //customer_phone_number = "05364346999";
            //customer_email = "yakupcicek0@gmasil.com";
            //customer_cıty = "Adana";
            //customer_district = "seyhan";

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("İsim: " + customer_name + " " + customer_surname);
            //Console.WriteLine("İletişim Bilgileri");
            //Console.WriteLine("Cep Telefonu: " + customer_phone_number);
            //Console.WriteLine("E-mail. " + customer_email);
            //Console.WriteLine("Adres: " + customer_cıty + "/" + customer_district);
            //Console.WriteLine("-----------------------------");
            //Console.ReadLine();

            #endregion

            #region Degiskenler(int)
            //int number;
            //number = 1453;
            //Console.WriteLine("Istanbul'un fethi " + number);
            //Console.Read();

            int hamburgerprice;
            int pizzaprice;
            int friseprice;
            int cokeprice;
            int lemonadeprice;
            int waterprice;

            hamburgerprice = 300;
            pizzaprice = 400;
            friseprice = 100;
            cokeprice= 100;
            lemonadeprice = 75;
            waterprice = 50;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("******Yemek Fiyat Listesi******");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger:           "+hamburgerprice);
            Console.WriteLine("Pizza:               "+pizzaprice);
            Console.WriteLine("Patates Kızartması:  "+friseprice);
            Console.WriteLine("Kola:                "+cokeprice);
            Console.WriteLine("Limonata:            "+lemonadeprice);
            Console.WriteLine("Su:                  "+waterprice);
            Console.WriteLine("-------------------------------");
            Console.ReadLine();

            int pizzacount;
            int hamburgercount;
            int frisecount;
            int cokecount;
            int lemonadecount;
            int watercount;

            pizzacount = 1;
            hamburgercount = 3;
            frisecount = 2;
            cokecount = 3;
            lemonadecount = 1;
            watercount = 3;

            int totalhambugerprice, totalpizzaprice, totalfriseprice, totalcokeprice, totallemonadeprice, totalwaterprice;
            totalhambugerprice = hamburgerprice * hamburgercount;
            totalpizzaprice=pizzacount * pizzacount;
            totalfriseprice = frisecount * friseprice;
            totalcokeprice = cokecount * cokeprice;
            totallemonadeprice = lemonadecount * lemonadeprice;
            totalwaterprice = watercount * waterprice;

            int totalprice;
            totalprice=totalhambugerprice+totalpizzaprice+totalfriseprice+totalcokeprice+totallemonadeprice+totalwaterprice;
            
            Console.WriteLine("-------------------------------");
            Console.WriteLine("************ Hesap ************");
            Console.WriteLine(hamburgercount + "x  Hamburger  " + totalhambugerprice + " Tl");
            Console.WriteLine(pizzacount + "x  Pizza  " + totalpizzaprice + " Tl");
            Console.WriteLine(frisecount + "x  Patates Kızartması  " + totalfriseprice + " Tl");
            Console.WriteLine(cokecount + "x  Kola  " + totalcokeprice + " Tl");
            Console.WriteLine(lemonadecount + "x  Limonata  " + totallemonadeprice + " Tl");
            Console.WriteLine(watercount + "x  Su  " + totalwaterprice + " Tl");
            Console.WriteLine();
            Console.WriteLine("Toplam Hesap:             " +totalprice);
            Console.WriteLine("-------------------------------");
            Console.ReadLine();




            #endregion


        }
    }
}
