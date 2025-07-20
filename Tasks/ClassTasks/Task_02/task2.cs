using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.ClassTasks.Task_02
{
    public class task2
    {
        public static void Main()
        {
            Bond bond = new Bond(1000m, 5.0m, new DateTime(2025, 07, 28));

            Console.WriteLine(bond.CalculateCouponPayment()); // 50 USD
            Console.WriteLine(bond.GetTimeToMaturity());      // Количество дней до 31.12.2030

        }
    }
}

public class Bond
{
    decimal FaceValue;
    decimal CouponRate;
    DateTime MaturityDate;

    public Bond(decimal faceValue, decimal couponRate, DateTime maturityDate)
    {
        FaceValue = faceValue;
        CouponRate = couponRate;
        MaturityDate = maturityDate;
    }

    public decimal CalculateCouponPayment()
    {
        return FaceValue * (CouponRate / 100);
    }

    public double GetTimeToMaturity()
    {
        return MaturityDate.Subtract(DateTime.Now).TotalDays;
    }
}
