using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("***Restoran Fiyat Listesi***");
            Console.WriteLine();

            int hamburgerPrice;
            int pizzaPrice;
            int friesPrice;
            int cokePrice;
            int lemonadePrice;
            int waterPrice;

            hamburgerPrice = 300;
            pizzaPrice = 250;
            friesPrice = 125;
            cokePrice = 50;
            lemonadePrice = 65;
            waterPrice = 30;

            Console.WriteLine("Hamburger=" + hamburgerPrice + "TL");
            Console.WriteLine("Pizza=" + pizzaPrice + "TL");
            Console.WriteLine("Kızartma=" + friesPrice + "TL");
            Console.WriteLine("Kola=" + cokePrice + "TL");
            Console.WriteLine("Limonata=" + lemonadePrice + "TL");
            Console.WriteLine("Su=" + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            int hamburgerCount;
            int pizzaCount;
            int friesCount;
            int cokeCount;
            int lemonadeCount;
            int waterCount;

            hamburgerCount = 5;
            pizzaCount = 2;
            friesCount = 2;
            cokeCount = 5;
            lemonadeCount = 2;
            waterCount = 2;

            int totalhamburgerprice = hamburgerCount * hamburgerPrice;
            int totalpizzaCount = pizzaCount * pizzaPrice;  
            int totalfriesCount = friesCount * friesPrice; 
            int totalCokeCount = cokeCount * cokePrice;
            int totallemonadeCount = lemonadeCount * lemonadePrice;
            int totalWaterCount = waterCount * waterPrice;
            Console.WriteLine();

            Console.WriteLine("Hamburger Fiyatı =" + totalhamburgerprice +"TL");
            Console.WriteLine("Pizza Fiyatı=" + totalpizzaCount +"TL");
            Console.WriteLine("Kızartma Fiyatı=" + totalfriesCount +"TL");
            Console.WriteLine("Kola Fiyatı=" + totalCokeCount +"TL");
            Console.WriteLine("Limonata Fiyatı=" + totallemonadeCount +"TL");
            Console.WriteLine("Su Fiyatı=" + totalWaterCount +"TL");
            Console.WriteLine();

            Console.WriteLine("------------------------");
            Console.WriteLine();
            int totalallprice;
            totalallprice = totalhamburgerprice + totalpizzaCount + totalfriesCount + totalCokeCount + totallemonadeCount + totalWaterCount;
            Console.WriteLine();


            Console.WriteLine("Toplam Ödenecek Tutar:" + totalallprice +"TL");
                Console.Read();
            
        }
    }
}
