// Ввести число и вывести его квадрат
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");
int sqr1 = Convert.ToInt32 (Math.Pow(number, 2)); // здесь может быть любая степень
Console.WriteLine($"Квадрат числа {number} равен {sqr1}");