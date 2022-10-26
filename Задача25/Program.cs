// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.WriteLine("Введите число A: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} равно: {Exponentiation (a)}");

double Exponentiation (double a)
{
    double result = 0;
    result=Math.Pow(a, b);
    return result;
}
