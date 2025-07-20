using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.ClassTasks.Task_05
{
    public class task5
    {
        public static void Main()
        {
            var contract = new SmartContract();

            contract.Execute();
            contract.Execute();
        }

    }
}

public class SmartContract
{
    bool _isExecuted = false;

    public void Execute()
    {
        if (_isExecuted == false)
        {
            Console.WriteLine("Контракт выполнен!");
            _isExecuted = true;
        }
        else
        {
            Console.WriteLine("Контракт уже был выполнен.");
        }
    }

}