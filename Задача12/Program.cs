// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если второе число не кратно числу первому, 
//то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно


Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

int ost = 0;
if (num2%num1 == 0)
{
    Console.WriteLine($"Число{num2} кратно {num1}");
    return;
}
else
{
    ost = num2%num1;
    Console.WriteLine($"Остаток от деления числа{num2} на {num1} равен {ost}");
}