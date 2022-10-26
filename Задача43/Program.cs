// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine());


Console.WriteLine($"Точка пересечения прямых y = {k1} * x + {b1} и y = {k2} * x + {b2}  равна ");

intersectionPoint(k1, b1, k2, b2);


void intersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = ((k1 * x) + b1);
    Console.WriteLine($"{x:f2},{y:f2}");
}