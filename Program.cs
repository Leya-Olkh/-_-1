/***Задача 8:**

**Условие:**

Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

**Например:**

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Clear();
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
for (int i = 0; i < number + 1; i+=2){
    Console.Write($"{i}");
}