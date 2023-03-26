/***Задача 2:**

**Условие:**

Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.

**Например:**

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Clear();
Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a == b}");
if(a == b)
{
    Console.Clear();
    Console.WriteLine($"{a} равно {b}");
}else
if(a < b)
{
    Console.WriteLine($"{a < b}");
    Console.Clear();
    Console.WriteLine($"{a} меньше {b}");
}else
{
    Console.Clear();
	Console.WriteLine($"{a} больше {b}");
}