using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int attempts = 0; 
        int low = 1;     
        int high = 100;    
        int guess;         

        Console.WriteLine("Комп'ютер загадав число від 1 до 100. Спробуйте вгадати його!");

        while (true)
        {
            guess = (low + high) / 2;
            attempts++; 

            Console.WriteLine($"Спроба #{attempts}: Ваша здогадка - {guess}");

            if (guess < secretNumber)
            {
                Console.WriteLine("Більше"); 
                low = guess + 1; 
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Менше");
                high = guess - 1; 
            }
            else
            {
                Console.WriteLine($"Вітаємо! Ви вгадали число {secretNumber} за {attempts} спроб.");
                break; 
            }
        }
    }
}
