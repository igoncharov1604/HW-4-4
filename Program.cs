using System;

public static class MathUtilities
{
    // Метод для створення масиву з чотирьох дійсних чисел, визначення мінімального та максимального значення
    public static void FindMinMaxInArray()
    {
        double[] numbers = { 12.5, -3.7, 9.0, 0.1 };  // Ініціалізація масиву

        // Знаходимо мінімальне і максимальне значення в масиві
        double min = numbers[0];
        double max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        // Виведення результатів на консоль
        Console.WriteLine($"Мінімальне число: {min}");
        Console.WriteLine($"Максимальне число: {max}");
    }

    // Метод для пошуку кількості вказаної цифри в масиві
    public static void FindOccurrences(int target)
    {
        int[] array = { 1, 2, 5, 3, 7, 5, 1, 3, 4 };  // Ініціалізація масиву
        int count = 0;

        // Лінійний пошук
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                count++;
            }
        }

        // Виведення результату
        Console.WriteLine($"Кількість числа {target} в масиві: {count}");
    }
}

class Program
{
    static void Main()
    {
        // Тестування першого методу
        Console.WriteLine("Тестування методу FindMinMaxInArray:");
        MathUtilities.FindMinMaxInArray();

        // Тестування другого методу
        Console.WriteLine("\nТестування методу FindOccurrences:");
        MathUtilities.FindOccurrences(5);  // Шукаємо число 5 в масиві
    }
}
