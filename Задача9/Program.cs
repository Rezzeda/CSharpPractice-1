// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear();

int num = new Random().Next(10,100);

int num1 = num/10;
int num2 = num%10;

if(num1 > num2){
    Console.WriteLine($"Цифра {num1} больше цифры {num2}");
}else{
    Console.WriteLine($"Цифра {num2} больше цифры {num1}");
}

