// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введитее трехзначное число: ");

int num = int.Parse(Console.ReadLine());

if (num < 100 || num > 999)
{
    Console.WriteLine("Число не трехзначное!");
    return;
}
else
{
    int num2 = num%100/10;
    Console.WriteLine($"{num2}");
}