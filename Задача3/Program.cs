// Программа, которая будет выдавать название дня недели по заданному номеру
Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number > 7||number < 1)
    {
        Console.WriteLine("В неделе только 7 дней");
        return;
    }
if (number == 1)
    {
        Console.WriteLine($"День {number} это Понедельник");
    }
if (number == 2)
    {
        Console.WriteLine($"День {number} это Вторник");
    }
if (number == 3)
    {
        Console.WriteLine($"День {number} это Среда");
    }
if (number == 4)
    {
        Console.WriteLine($"День {number} это Четверг");
    }
if (number == 5)
    {
        Console.WriteLine($"День {number} это Пятница");
    }
if (number == 6)
    {
        Console.WriteLine($"День {number} это Суббота");
    }
if (number ==7)
    {
        Console.WriteLine($"День {number} это Воскресенье");
    }