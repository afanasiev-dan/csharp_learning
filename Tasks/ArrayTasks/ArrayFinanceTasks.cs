namespace Tasks;

using System;
using System.Diagnostics.Metrics;

public static class ArrayFinanceTasks
{
    /// <summary>
    /// Задача 1: Генерация массива цен акций
    /// Требуется: Создать массив случайных цен в заданном диапазоне
    /// Пример: days=3, min=100, max=200 → [150.50, 180.00, 132.75]
    /// </summary> 
    public static decimal[] GenerateStockPrices(int days, decimal minPrice, decimal maxPrice)
    {
        days = 3;

        int size = days * 24;

        int minValue = 100;
        int maxValue = 200;

        Random random = new Random();

        decimal[] randNumb = new decimal[size];

        for (int i = 0; i < size; i++)
        {
            randNumb[i] = random.Next(minValue, maxValue);
        }

        int counter = 0;
        foreach (decimal number in randNumb)
        {
            counter++;
            Console.WriteLine(counter + ". " + number);
        }

        return randNumb;
    }

    /// <summary>
    /// Задача 2: Расчет стоимости крипто-портфеля
    /// Требуется: Рассчитать общую стоимость криптоактивов
    /// Формула: сумма(количество_монет * цена_за_монету)
    /// Пример: amounts=[0.5, 2], price=40000 → (0.5+2)*40000 = 100000
    /// </summary>
    public static decimal CalculatePortfolioValue(decimal[] amounts, decimal pricePerUnit)
    {

        decimal amount = 0;
        for (int i = 0; i < amounts.Length; i++)
        {
            amount += pricePerUnit * amounts[i];
        }

        Console.WriteLine(amount);
        return amount;
    }

    /// <summary>
    /// Задача 3: Поиск максимальной цены за период
    /// Требуется: Найти максимальное значение в массиве цен
    /// Пример: [45000, 47850, 43200] → 47850
    /// Особенность: Использует встроенный метод Max() для decimal[]
    /// </summary> 
    public static decimal FindMaxPrice(decimal[] prices)
    {
        decimal maxValue = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] > maxValue)
            {
                maxValue = prices[i];
            }
        }
        Console.WriteLine(maxValue);
        return maxValue;
    }

    /// <summary>
    /// Задача 4: Расчет средней доходности облигаций
    /// Требуется: Вычислить среднее арифметическое массива доходностей
    /// Пример: yields=[5.0, 4.5, 6.2] → (5.0+4.5+6.2)/3 = 5.23
    /// Важно: Результат округляется до 2 знаков после запятой
    /// </summary>
    public static double CalculateAverageYield(double[] yields)
    {
        double yield = 0;
        for (int i = 0; i < yields.Length; i++)
        {
            yield += yields[i] / yields.Length;
        }

        Console.WriteLine(Math.Round(yield, 2));
        return yield;
    }

    /// <summary>
    /// Задача 5: Поиск дней с ростом цены ("бычьих" дней)
    /// Требуется: Найти индексы дней, когда цена была выше предыдущего дня
    /// Пример: [100, 99, 107, 109, 103] → [1,2,3] (только второй день показал рост)
    /// Особенность: Первый день (индекс 0) никогда не может быть "бычьим"
    /// </summary>
    public static int[] FindBullDays(decimal[] prices)
    {
        List<int> index = new();
        decimal previousDay = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] > previousDay)
            {
                previousDay = prices[i];
                if (i != 0)
                {
                    index.Add(i);
                    Console.WriteLine(i);
                }
            }
        }
        return index.ToArray();
    }

    /// <summary>
    /// Задача 6: Подсчет убыточных дней
    /// Требуется: Посчитать количество дней с отрицательной доходностью
    /// Пример: changes=[-2.5, 1.3, -4.7] → 2
    /// Логика: Счетчик увеличивается при значениях меньше нуля
    /// </summary>
    public static int CountLossDays(double[] dailyChanges)
    {
        int days = 0;

        for (int i = 0; i < dailyChanges.Length; i++)
        {
            if (dailyChanges[i] < 0)
            {
                days++;
            }
        }
        Console.WriteLine(days);

        return days;
    }

    /// <summary>
    /// Задача 7: Конвертация BTC в USD
    /// Требуется: Преобразовать массив сумм в BTC в USD по текущему курсу
    /// Пример: amounts=[0.1, 0.5], rate=45000 → [4500, 22500]
    /// Важно: Результат сохраняет тип decimal для точных расчетов
    /// </summary>
    public static decimal[] ConvertBTCtoUSD(decimal[] btcAmounts, decimal exchangeRate)
    {
        decimal usdPrice;
        List<decimal> amount = new();
        for (int i = 0;i < btcAmounts.Length; i++)
        {
            usdPrice = btcAmounts[i] * exchangeRate;
            amount.Add(usdPrice);
         Console.WriteLine(usdPrice);
        }

        return amount.ToArray();
    }

    /// <summary>
    /// Задача 8: Применение стоп-лосса к изменениям цен
    /// Требуется: Заменить все отрицательные изменения на 0
    /// Пример: Исходный массив [-2.5, 1.3, -4.7] → [0, 1.3, 0]
    /// Особенность: Модифицирует исходный массив (in-place)
    /// </summary> 
    public static void ApplyStopLoss(double[] priceChanges)
    {
        for (int i = 0; i < priceChanges.Length; i++)
        {
            if (priceChanges[i] < 0)
            {
                priceChanges[i] = 0;
            }
            Console.WriteLine(priceChanges[i]);
        }
    }

    /// <summary>
    /// Задача 9: Поиск первого превышения ценового уровня
    /// Требуется: Найти индекс первого элемента, превышающего лимит
    /// Пример: prices=[48000, 49000, 51000], limit=50000 → 2
    /// Возвращает: -1 если ни один элемент не превысил лимит
    /// </summary> 
    public static int FindFirstPriceAbove(decimal[] prices, decimal limit)
    {
        int index = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] > limit)
            {
                index = i;
                Console.WriteLine(i);
            }
        }
        return index;
    }

    /// <summary>
    /// Задача 10: Сдвиг данных за неделю
    /// Требуется: Сдвинуть элементы массива вправо на 1 позицию
    /// Пример: [100, 200, 300] → [300, 100, 200]
    /// Применение: Имитация перехода к новой неделе в исторических данных
    /// </summary>
    //public static decimal[] ShiftWeeklyData(decimal[] prices)
    //{
    //    decimal lastElement = 0;

    //    for (int i = 0; i < prices.Length; i++)
    //    {
    //        lastElement = prices.Length - i;
    //    }
    //}

    /// <summary>
    /// Пример использования всех методов с выводом в консоль
    /// Демонстрирует последовательность вызовов и форматы данных
    /// </summary>
    public static void DemoAllTasks()
    {
        //Console.WriteLine("=== Финансовый анализ ===");

        //// 1. Генерация цен
        //var prices = GenerateStockPrices(5, 100, 200);
        //Console.WriteLine($"Сгенерированные цены: {string.Join(" | ", prices)}");

        //// 2. Расчет портфеля
        //decimal[] btcAmounts = { 0.5m, 2.1m };
        //Console.WriteLine($"Стоимость BTC: {CalculatePortfolioValue(btcAmounts, 45000m):C}");

        //// 5. Бычьи дни
        //var examplePrices = new decimal[] { 100, 105, 103, 107 };
        //Console.WriteLine($"Дни роста: {string.Join(", ", FindBullDays(examplePrices))}");

        //// 10. Сдвиг данных
        //var shifted = ShiftWeeklyData(examplePrices);
        //Console.WriteLine($"После сдвига: {string.Join(" → ", shifted)}");
        //GenerateStockPrices(3, 100, 200);
        //CalculatePortfolioValue([0.5m,2] , 40000);
        //FindMaxPrice([45000, 47500, 43000]);
        //CalculateAverageYield([5.0, 4.5, 6.2]);
        //FindBullDays([100, 99, 107, 109, 103]);
        //CountLossDays([-2.5, 1.3, -4.7]);
        //ConvertBTCtoUSD([0.1m, 0.5m], 45000);
        //ApplyStopLoss([-2.5, 1.3, -4.7]);
        //FindFirstPriceAbove([48000, 49000, 51000], 50000);

    }
}