using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.ClassTasks.Task_01
{
    public class task1
    {

        public static void Main()
        {
            Stock stock = new("TSLA", 250.75m, 1.2);

            stock.printInfo();

        }
    }


    public class Stock
    {
        public string Ticker;
        public decimal Price;
        public double DividendYield;

        public Stock(string ticker, decimal price, double dividendYield)
        {
            Ticker = ticker;
            Price = price;
            DividendYield = dividendYield;
        }

        public void printInfo()
        {
            Console.WriteLine($"Ticker: {Ticker}, {Price}$, (DividendYield: {DividendYield}%)");
        }
    }
}
