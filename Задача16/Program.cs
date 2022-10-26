// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
Console.Clear();
Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2*num2)
{
    Console.WriteLine($" Первое число является квадратом второго");
    return;
}

if (num2 == num1*num1)
{
    Console.WriteLine($" Второе число является квадратом первого");
    return;
}

else
{
    Console.WriteLine($"одно число НЕ является квадратом другого");
}
