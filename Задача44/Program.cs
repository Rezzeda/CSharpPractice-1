// Не испоьзуя рекурсию, выведите первые n Чисел Фибоначчи
// Числа Фибоначчи - последовательность, каждый элемент которой равен сумме двух предыдущих.

Console.Clear();
int countTests = 40;


DateTime saveTime;

Console.WriteLine($"Цикл for: ");
saveTime = DateTime.Now;
int fibonacci1 = 1;
int fibonacci2 = 1;
for (int i = 1; i <= countTests; i++)
{
Console.WriteLine($"f({i}) = {fibonacci2}");
int temporary = fibonacci2;
fibonacci2 += fibonacci1;
fibonacci1 = temporary;
}
Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");

// рекурсия
Console.WriteLine($"FibonacciBad: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{

Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
}
Console.WriteLine($"Для FibonacciBad прошло: {DateTime.Now - saveTime}");
Console.WriteLine($"FibonacciGood: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{
Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
}
Console.WriteLine($"Для FibonacciR прошло: {DateTime.Now - saveTime}");
