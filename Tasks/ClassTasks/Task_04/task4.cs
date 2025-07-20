using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.ClassTasks.Task_04
{
    public class task4
    {
        public static void Main()
        {
            CryptoWallet wallet = new CryptoWallet();

            wallet.BtcAmount = 0.5m;
            wallet.BtcAmount = -1m;
            Console.WriteLine(wallet.BtcAmount);
        }

    }
}

public class CryptoWallet
{
    decimal _btcBalance;
    public decimal BtcAmount
    {
        get
        {
            return _btcBalance;
        }
        set
        {

            if (value < 0)
            {
                Console.WriteLine("Ошибка! баланс не может быть отрицательным");
            }
            else
            {
                _btcBalance = value;
            }
        }

    }
}
