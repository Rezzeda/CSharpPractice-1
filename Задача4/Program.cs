// Программа которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = 0;
if (number1 > number2)
    {
        max = number1;
    }
else 
    {
        max = number2;
    }
if (max > number3)
    {
    Console.WriteLine($"Максимальное число {max}");
    return;
    }
else 
    {
        max = number3;
    }
Console.WriteLine($"Максимальное число {max}");
