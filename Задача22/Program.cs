// напишите программу, которая принимает число N и выдает таблицу квадратов чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число: ");
double n = double.Parse(Console.ReadLine());
int i = 1;
while(i<=n)
{
    double a = Math.Pow(i,2);
    i++;
    Console.WriteLine($"{a}");
}
