using System;

class Program
{
    static void Main()
    {
        int[] mas = { 10, -3, 1, 4, -5, 2 };
        int N = mas.Length;

        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine();

        int[] positive = new int[20];
        int posCount = 0;
        for (int i = 0; i < N; i++)
        {
            if (mas[i] > 0)
            {
                positive[posCount] = i; 
                posCount++;
            }
        }

        for (int i = 0; i < posCount / 2; i++)
        {
            int firstIndex = positive[i]; 
            int lastIndex = positive[posCount - 1 - i]; 
            int temp = mas[firstIndex];
            mas[firstIndex] = mas[lastIndex];
            mas[lastIndex] = temp;
        }
        Console.WriteLine("Результуючий масив:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine();
    }
}
