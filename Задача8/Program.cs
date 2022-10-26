// Программа, которая на вход принимает число N, на выходе показывает все четные чиcла от 1 до N
Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N < 1) 
    {
        Console.WriteLine("Введено число меньше 1");
        return;
    }

else
    {
        int b = 0;
        while (b < N)
        {
            b = b + 2;
            Console.WriteLine($"{b}");
        }
        
    }