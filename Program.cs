// See https://aka.ms/new-console-template for more information
double a = 0, b = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine("Выберите опцию:");
    Console.WriteLine("1. Ввести А");
    Console.WriteLine("2. Ввести B");
    Console.WriteLine("3. Выполнить операцию «+»");
    Console.WriteLine("4. Выполнить операцию «-»");
    Console.WriteLine("5. Выполнить операцию «*»");
    Console.WriteLine("6. Выполнить операцию «/»");
    Console.WriteLine("7. Выйти из программы");

    ConsoleKeyInfo key = Console.ReadKey();

    switch (key.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            Console.WriteLine("\nВведите значение А:");
            a = Convert.ToDouble(Console.ReadLine());
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            Console.WriteLine("\nВведите значение B:");
            b = Convert.ToDouble(Console.ReadLine());
            break;
        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:
            Console.WriteLine($"\nРезультат операции «+»: {a} + {b} = {a + b}");
            Console.ReadKey();
            break;
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:
            Console.WriteLine($"\nРезультат операции «-»: {a} - {b} = {a - b}");
            Console.ReadKey();
            break;
        case ConsoleKey.D5:
        case ConsoleKey.NumPad5:
            Console.WriteLine($"\nРезультат операции «*»: {a} * {b} = {a * b}");
            Console.ReadKey();
            break;
        case ConsoleKey.D7:
        case ConsoleKey.NumPad7:
            return;
        default:
            Console.WriteLine("\nНеверный выбор. Попробуйте снова.");
            Console.ReadKey();
            break;
    }
}