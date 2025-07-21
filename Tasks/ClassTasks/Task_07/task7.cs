using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.ClassTasks.Task_07
{
    public class task7
    {
        public static void Main()
        {
            decimal price = PriceGenerator.GenerateRandomPrice(100m, 200m);

        }

    }
}

public static class PriceGenerator
{
    static Random rnd = new Random();
    public static decimal GenerateRandomPrice(decimal min, decimal max)
    {
        double price = rnd.NextDouble();
        decimal priceDec = Math.Round(min + (decimal)price * (max - min), 2);
        Console.WriteLine(priceDec);
        return priceDec;
    }
}