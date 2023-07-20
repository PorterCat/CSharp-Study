using System;

namespace StockOnliner
{
    class Programm
    {
        static void Main(string[] args)
        {
            StackExchangeMonitor stackExchangeMonitor = new StackExchangeMonitor();
            stackExchangeMonitor.PriceChangeHandler = ShowPrice;
            stackExchangeMonitor.Start();
        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price is: {price}");
        }
    }
}