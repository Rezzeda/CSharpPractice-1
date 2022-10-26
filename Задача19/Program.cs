// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());

if(n>9999 && n<100000)
{
    int n1 = n/10000;
    int n2 = n/1000%10;

    int n4 = n/10%10;
    int n5 = n%10;

    if(n1==n5 && n2==n4)
    {
        Console.WriteLine($"Число {n} является палиндромом");
    }

    else
    {
        Console.WriteLine($"Число {n} НЕ является палиндромом");
    }
}
else 
{
    Console.WriteLine($"Число {n} не пятизначное!");
}

