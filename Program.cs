﻿/***Задача 4:**

**Условие:**

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

**Например:**

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Clear();
Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());
Console.Write("c:");
int c = int.Parse(Console.ReadLine());
int max = 0;
Console.WriteLine($"{a < b}");
if(a > b)
{
    Console.WriteLine($"{max = a}");
}else
{
	Console.WriteLine($"{max = b}");
}
Console.WriteLine($"{max > c}");
if(max > c)
{
    Console.Clear();
    int sqr = max;
    Console.WriteLine($"Максимальное число {sqr}");
}else
{
    Console.Clear();
    int sqr = c;
    Console.WriteLine($"Максимальное число {sqr}");
}