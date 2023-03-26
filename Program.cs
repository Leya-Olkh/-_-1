/***Задача 6:**

**Условие:**

Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).

**Например:**

4 -> да
-3 -> нет
7 -> нет*/

Console.Clear();
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
if(number%2 != 0)
{
    Console.Clear();
    Console.WriteLine($"Число {number} нечётное");
}else
{
    Console.Clear();
    Console.WriteLine($"Число {number} чётное");
}