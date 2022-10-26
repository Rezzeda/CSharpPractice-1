// Программа, которая принимает число на вход и выдает является ли число четным (делится ли на 2 без остатка).
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number%2==1)
    {
        Console.WriteLine($"Число {number} - нечетное");
    }
else 
    {
        Console.WriteLine($"Число {number} - четное");
    }   