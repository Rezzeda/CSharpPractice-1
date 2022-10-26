// программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// АВ=√(xb-xa)2 +(xb-xa)2
Console.Clear();
Console.WriteLine("Введите координату X первой точки: ");
double xa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
double ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки: ");
double xb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
double yb = double.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2));

Console.WriteLine($"{AB:f3}");