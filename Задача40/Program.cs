// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторoнами такой длины. 1 способ.

Console.Clear();
Console.Write("Введите три числа через пробел: ");
string elements = Console.ReadLine();
int[] arr = GetArrayFromString(elements);

Console.WriteLine($"[{String.Join(" ", elements)}]");
Triangle(arr);

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

void Triangle(int[] arr)
{
    if (arr[0] + arr[1] > arr[2] && arr[1] + arr[2] > arr[0] && arr[2] + arr[0] > arr[1])
    {
        Console.WriteLine($"[Треугольник существует]");
    }
    else
    {
        Console.WriteLine($"[Треугольник НЕ существует]");
    }
}



