// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number > 7||number < 1)
    {
        Console.WriteLine("В неделе только 7 дней");
        return;
    }
if (number < 6)
    {
        Console.WriteLine($"День недели № {number} это рабочий день!");
    }
if (number >= 6)
    {
        Console.WriteLine($"День {number} это ВЫХОДНОЙ!");
    }
