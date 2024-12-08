using System;

class Program
{
    // Клас для зберігання конфігурації
    class Configuration
    {
        public string OperatingSystem;
        public string Database;
        public int MinExternalMemory; // Мінімальний об’єм зовнішньої пам’яті (MB)
        public int MinRAM;            // Мінімальний об’єм оперативної пам’яті (MB)
        public int Price;             // Приблизна ціна ($)
    }

    static void Main()
    {
        // Створюємо масив конфігурацій
        Configuration[] configurations = new Configuration[3];

        // Заповнюємо масив даними
        configurations[0] = new Configuration { OperatingSystem = "OS/2", Database = "DB2", MinExternalMemory = 130, MinRAM = 22, Price = 3343 };
        configurations[1] = new Configuration { OperatingSystem = "Windows/NT", Database = "SQLServer", MinExternalMemory = 230, MinRAM = 24, Price = 2685 };
        configurations[2] = new Configuration { OperatingSystem = "SCO/Unix", Database = "Oracle", MinExternalMemory = 110, MinRAM = 48, Price = 3745 };

        // Виводимо заголовок таблиці
        Console.WriteLine("Операційна система | СУБД        | Мін. зовнішня пам’ять (MB) | Мін. оперативна пам’ять (MB) | Приблизна ціна ($)");
        Console.WriteLine("-------------------------------------------------------------------------------------------");

        // Виводимо дані конфігурацій
        foreach (Configuration config in configurations)
        {
            Console.WriteLine("{0,-18} | {1,-10} | {2,26} | {3,28} | {4,14}",
                config.OperatingSystem, config.Database, config.MinExternalMemory, config.MinRAM, config.Price);
        }

        // Додаємо примітку
        Console.WriteLine("\nПримітка: приймалася ціна ліцензії на 8 користувачів.");
    }
}
