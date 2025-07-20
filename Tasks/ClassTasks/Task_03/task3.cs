using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.ClassTasks.Task_03
{
    public class task3
    {
        public static void Main()
        {
            Order order = new Order(OrderType.Bye, 10, 150m);

            Console.WriteLine(order.GetTotalValue());
        }
    }


}

public class Order
{
    OrderType Type;
    decimal Amount;
    decimal Price;

    public Order(OrderType type, decimal amount, decimal price)
    {
        Type = type;
        Amount = amount;
        Price = price;
    }

    public decimal GetTotalValue()
    {
        return Amount * Price;
    }
}

public enum OrderType
    {
        Bye,
        Sell
    }
