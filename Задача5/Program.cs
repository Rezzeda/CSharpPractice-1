// Написать программу которая на вход принимает одно число N, а на выходе показывает все целые числа от -N до N
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if(n<0)
    {
        n=-n;
    }
int b = -n;
while (b<=n)
    {
        Console.WriteLine($"{b}");
        b++;
    }