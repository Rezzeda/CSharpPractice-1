// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// АВ=√(xb-xa)2 +(yb-ya)2 + (zb-za)2

Console.Clear();
Console.WriteLine("Введите координату X первой точки: ");
double xa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
double ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
double za = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки: ");
double xb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
double yb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
double zb = double.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));

Console.WriteLine($"{AB:f3}");
