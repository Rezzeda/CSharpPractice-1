// Программа, которая по заданному номеру четвчерти показывает диапазон возможных координат точек
//в этой четверти

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

if(num<1 || num>4)
{
    Console.WriteLine("Некорректно введен номер четверти");
}

if(num==1)
{
    Console.WriteLine("X>0 && Y>0");
}

if(num==2)
{
    Console.WriteLine("X<0 && Y>0");
}

if(num==3)
{
    Console.WriteLine("X<0 && Y<0");
}
if(num==4)
{
    Console.WriteLine("X>0 && Y<0");
}