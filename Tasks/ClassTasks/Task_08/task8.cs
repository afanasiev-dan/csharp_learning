using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.ClassTasks.Task_08
{
    public class task8
    {
        public static void Main()
        {
            Asset asset1 = new Stock("Apple", 150m);
            Asset asset2 = new BonD("Gov Bond", 1000m);
            Console.WriteLine(asset1.GetAssetType());
            Console.WriteLine(asset2.GetAssetType());
        }

    }
}

public class Asset
{
    public string Name;
    public decimal Price;


    public Asset(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual string GetAssetType()
    {
        Console.WriteLine($"Name {Name}, Price: {Price}");
        return "Базовый актив"; 
    }
}

public class Stock : Asset
{
    public double DividendYield;

    public Stock(string name, decimal price) : base(name, price)
    {
        Name = name;
        Price = price;
    }

    public override string GetAssetType()
    {
        return "Акция";
    }
}

public class BonD : Asset
{
    DateTime MaturityDate;

    public BonD(string name, decimal price) : base(name, price) 
    {
        Name = name;
        Price = price;
    }
    public override string GetAssetType()
    {
        return "Облигация";
    }
}