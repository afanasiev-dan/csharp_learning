namespace Tasks;

using System;

public static class ArrayFinanceTasks
{
    /// <summary>
    /// Задача 1: Генерация массива цен акций
    /// Требуется: Создать массив случайных цен в заданном диапазоне
    /// Пример: days=3, min=100, max=200 → [150.50, 180.00, 132.75]
    /// </summary> 
    public static decimal[] GenerateStockPrices(int days, decimal minPrice, decimal maxPrice)
    {
        throw new NotImplementedException(); 
    }

    /// <summary>
    /// Задача 2: Расчет стоимости крипто-портфеля
    /// Требуется: Рассчитать общую стоимость криптоактивов
    /// Формула: сумма(количество_монет * цена_за_монету)
    /// Пример: amounts=[0.5, 2], price=40000 → (0.5+2)*40000 = 100000
    /// </summary>
    public static decimal CalculatePortfolioValue(decimal[] amounts, decimal pricePerUnit)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задача 3: Поиск максимальной цены за период
    /// Требуется: Найти максимальное значение в массиве цен
    /// Пример: [45000, 47850, 43200] → 47850
    /// Особенность: Использует встроенный метод Max() для decimal[]
    /// </summary> 
    public static decimal FindMaxPrice(decimal[] prices)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задача 4: Расчет средней доходности облигаций
    /// Требуется: Вычислить среднее арифметическое массива доходностей
    /// Пример: yields=[5.0, 4.5, 6.2] → (5.0+4.5+6.2)/3 = 5.23
    /// Важно: Результат округляется до 2 знаков после запятой
    /// </summary>
    public static double CalculateAverageYield(double[] yields)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задача 5: Поиск дней с ростом цены ("бычьих" дней)
    /// Требуется: Найти индексы дней, когда цена была выше предыдущего дня
    /// Пример: [100, 105, 103] → [1] (только второй день показал рост)
    /// Особенность: Первый день (индекс 0) никогда не может быть "бычьим"
    /// </summary>
    public static int[] FindBullDays(decimal[] prices)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задача 6: Подсчет убыточных дней
    /// Требуется: Посчитать количество дней с отрицательной доходностью
    /// Пример: changes=[-2.5, 1.3, -4.7] → 2
    /// Логика: Счетчик увеличивается при значениях меньше нуля
    /// </summary>
    public static int CountLossDays(double[] dailyChanges)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задача 7: Конвертация BTC в USD
    /// Требуется: Преобразовать массив сумм в BTC в USD по текущему курсу
    /// Пример: amounts=[0.1, 0.5], rate=45000 → [4500, 22500]
    /// Важно: Результат сохраняет тип decimal для точных расчетов
    /// </summary>
    public static decimal[] ConvertBTCtoUSD(decimal[] btcAmounts, decimal exchangeRate)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задача 8: Применение стоп-лосса к изменениям цен
    /// Требуется: Заменить все отрицательные изменения на 0
    /// Пример: Исходный массив [-2.5, 1.3, -4.7] → [0, 1.3, 0]
    /// Особенность: Модифицирует исходный массив (in-place)
    /// </summary> 
    public static void ApplyStopLoss(double[] priceChanges)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задача 9: Поиск первого превышения ценового уровня
    /// Требуется: Найти индекс первого элемента, превышающего лимит
    /// Пример: prices=[48000, 49000, 51000], limit=50000 → 2
    /// Возвращает: -1 если ни один элемент не превысил лимит
    /// </summary> 
    public static int FindFirstPriceAbove(decimal[] prices, decimal limit)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Задача 10: Сдвиг данных за неделю
    /// Требуется: Сдвинуть элементы массива вправо на 1 позицию
    /// Пример: [100, 200, 300] → [300, 100, 200]
    /// Применение: Имитация перехода к новой неделе в исторических данных
    /// </summary>
    public static decimal[] ShiftWeeklyData(decimal[] prices)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Пример использования всех методов с выводом в консоль
    /// Демонстрирует последовательность вызовов и форматы данных
    /// </summary>
    public static void DemoAllTasks()
    {
        Console.WriteLine("=== Финансовый анализ ===");
            
        // 1. Генерация цен
        var prices = GenerateStockPrices(5, 100, 200);
        Console.WriteLine($"Сгенерированные цены: {string.Join(" | ", prices)}");

        // 2. Расчет портфеля
        decimal[] btcAmounts = { 0.5m, 2.1m };
        Console.WriteLine($"Стоимость BTC: {CalculatePortfolioValue(btcAmounts, 45000m):C}");

        // 5. Бычьи дни
        var examplePrices = new decimal[] { 100, 105, 103, 107 };
        Console.WriteLine($"Дни роста: {string.Join(", ", FindBullDays(examplePrices))}");

        // 10. Сдвиг данных
        var shifted = ShiftWeeklyData(examplePrices);
        Console.WriteLine($"После сдвига: {string.Join(" → ", shifted)}");
    }
}