// Напишите программу, которая будет преобразовывать десятичное число в двоичное

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

string res1 = Convert.ToString(n, 2);
string res2 = DecToNum(n, 16);

Console.WriteLine($"{n} -> {res1} ");
Console.WriteLine($"{n} -> {res2} ");


// Универсальный математический для перевода из десятичной в любую

string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}