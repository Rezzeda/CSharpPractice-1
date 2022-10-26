// напишите программу, кторая принимает на вход число (А) и выдает сумму чисел от 1 до А

Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int GetSum (int a)
{
    int sum=0;
    for (int i=1; i<=a; i++)
    sum += i;
    return sum;
}


Console.WriteLine($"Сумма чискл от 1 до {a} равна {GetSum (a)}");