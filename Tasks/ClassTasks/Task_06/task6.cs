using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.ClassTasks.Task_06
{
    public class task6
    {
        public static void Main()
        {
            decimal euro = FiatConverter.UsdToEUR(100);
            decimal dollars = FiatConverter.EurToUSDT(100);
        }

    }
}

public static class FiatConverter
{
    static  decimal _usdToEurRate = 0.92m;
  
    
    public static decimal UsdToEUR(decimal usd)
    {
       decimal amount = usd* _usdToEurRate;
        Console.WriteLine(amount);
        return amount;
    }
    public static decimal EurToUSDT(decimal eur)
    {
        decimal amount = eur / _usdToEurRate;
        Console.WriteLine(Math.Round(amount, 2));
        return amount;
    }
}
