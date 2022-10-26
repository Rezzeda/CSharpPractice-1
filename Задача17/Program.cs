// Программа, которая принимает на вход координаты точки X и Y, 
// причем X≠0 и Y≠0 и выдает номер четверти плоскости в которой находится эта точка.
Console.Clear();
Console.WriteLine("Введите X: ");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if(X>0 && Y>0)
{
    Console.WriteLine("1");
}

if(X<0 && Y>0)
{
    Console.WriteLine("2");
}

if(X<0 && Y<0)
{
    Console.WriteLine("3");
}

if(X>0 && Y<0)
{
    Console.WriteLine("4");
}