//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());


Console.WriteLine($"Сумма цифр в числе {n} равна: {SumDigits (n)}");

int SumDigits (int n)
{
    int sum = 0;
    while (n>0)
    {
        sum = sum+n%10;
        n = n/10;
    }
    return sum;
}