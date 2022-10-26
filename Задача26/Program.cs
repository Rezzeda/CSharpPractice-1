// Написать программу, которая принимает число и выдает количество цифр в числе
Console.Clear();
Console.WriteLine("Введите число: ");
int limit = int.Parse(Console.ReadLine());

int CountDigit (int limit)
{
    int i=0;
    while (limit>0)
    {
        i=i+1;
        limit=limit/10;
    }
    return i;
}
Console.WriteLine($"Количество цифр в числе {limit} равно {CountDigit(limit)}");