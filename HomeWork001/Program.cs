﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
// если А больше Б выполняем то что внутри
//if (a > b)
//    Console.WriteLine("a = "+a+" b = "+b+" -> max = "+a);
//else  
//Console.WriteLine("a = "+a+" b = "+b+" -> max = "+b);


Console.WriteLine("a = "+a+" b = "+b+" -> max = "+Math.Max(a, b));

//Math.Max(double a, double b): возвращает максимальное число из a и b