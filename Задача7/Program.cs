// Программа. которая на вход принимает трехзначное число. на выход показывает последнюю цифру этого числа
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

if (n < 100||n > 999)
    {
        Console.WriteLine("Введено не трехзначное число");
    }
else
    {
        int lastdigit = n%10;
        Console.WriteLine($"Последняя цифра: {lastdigit} ");
    }
