// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите числа через пробел: ");
string elements = Console.ReadLine();
int[] arr = GetArrayFromString(elements);

Console.WriteLine($"[{String.Join(" ", elements)}]");
Console.WriteLine($"Количество чисел > 0 = {countPositiveNumbers(arr)}]");

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int countPositiveNumbers(int [] arr)
{
     int count=0;
     foreach (var item in arr)
    {
        if (item>0) count++;
    }
    return count;
}