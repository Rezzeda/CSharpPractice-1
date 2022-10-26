// Написать программу, которая принимает число N и выдает произведение чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число: ");
int limit = int.Parse(Console.ReadLine());

Console.WriteLine($"произведение чисел от 1 до {limit} равно {Product(limit)}");

int Product (int limit)
{
       int result = 1;
    for (int i=1; limit>=i; i++)
    {
        result = result*i;
    }
    return result;
}
