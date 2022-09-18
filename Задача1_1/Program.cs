// Написать программу котрая на вход принимает 2 числа, и проверяет, является ли первое число квадратом второго.
Console.Clear();
Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2)
    {
        Console.WriteLine($"Число {number1} является квадратом числа {number2}");
    }
else
    {
    Console.WriteLine($"Число {number1} НЕ является квадратом числа {number2}");
    }