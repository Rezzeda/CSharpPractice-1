// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
using System;
using static System.Console;

Clear();

Write("Введите A: ");
int a = int.Parse(ReadLine());

Write("Введите B: ");
int b = int.Parse(ReadLine());

WriteLine(GetPower(a, b));

int GetPower(int a, int b) {
    if(b == 0) {
        return 1;
    }
    if(b == 1) {
        return a;
    }
    if(b % 2 == 1) {
        return (a * GetPower(a * a, (b - 1)/2));  
    }
    return(a * GetPower(a, b - 1));
}