// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
double n = double.Parse(Console.ReadLine());
int i = 1;
while(i<=n)
{
    double a = Math.Pow(i,3);
    i++;
    Console.Write($"{a} ");
}

