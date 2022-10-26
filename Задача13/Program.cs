// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введитее число: ");

int num = int.Parse(Console.ReadLine());
int num3 =-1;
while (num > 99)
{
    num3 = num%10;
    num = num/10;
}
if (num3 >= 0)
{
    Console.WriteLine($"Третья цифра {num3}");
}
else
{
       Console.WriteLine("Третьей цифры нет!");
}