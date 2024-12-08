using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        int result = ProductOfOddElements(array, array.Length - 1);
        Console.WriteLine($"Добуток непарних елементів: {result}");
    }

    static int ProductOfOddElements(int[] array, int index)
    {
        if (index < 0)
            return 1;

        if (array[index] % 2 != 0)
            return array[index] * ProductOfOddElements(array, index - 1); // Множимо на рекурсивний виклик
        else
            return ProductOfOddElements(array, index - 1); // Пропускаємо парний елемент
    }
}
