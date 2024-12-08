using System;

class Program
{
    static void Main()
    {
        // Комп'ютер загадує випадкове число від 1 до 100
        Random random = new Random();
        int secretNumber = random.Next(1, 101);  // Генеруємо випадкове число від 1 до 100
        int attempts = 0;  // Лічильник спроб
        int low = 1;       // Нижня межа для бінарного пошуку
        int high = 100;    // Верхня межа для бінарного пошуку
        int guess;         // Число, яке програма припускає

        Console.WriteLine("Комп'ютер загадав число від 1 до 100. Спробуйте вгадати його!");

        while (true)
        {
            // Здогадка як середнє значення між low та high
            guess = (low + high) / 2;
            attempts++; // Збільшуємо кількість спроб

            Console.WriteLine($"Спроба #{attempts}: Ваша здогадка - {guess}");

            if (guess < secretNumber)
            {
                Console.WriteLine("Більше"); // Якщо здогадка менша за загадане число
                low = guess + 1; // Зміщуємо нижню межу
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Менше"); // Якщо здогадка більша за загадане число
                high = guess - 1; // Зміщуємо верхню межу
            }
            else
            {
                // Якщо вгадали
                Console.WriteLine($"Вітаємо! Ви вгадали число {secretNumber} за {attempts} спроб.");
                break; // Вихід з циклу
            }
        }
    }
}
