// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторoнами такой длины. 2 способ.

Console.Clear();
Console.Write("Введите три числа через пробел: ");
string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

if (IsTriangle(int.Parse(elements[0]), int.Parse(elements[1]), int.Parse(elements[2])))
{
    Console.WriteLine("DA");
}
else
{
    Console.WriteLine("NET");
}

bool IsTriangle(int a, int b, int c)
{
    return (((a + b) > c && (a + c) > b && (b + c) > a));
}