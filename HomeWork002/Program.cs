// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
// из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число с: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine("a = "+a+", b = "+b+", c = "+c+", -> = "+Math.Max(a,c));
    
else 
    Console.WriteLine("a = "+a+", b = "+b+", c = "+c+", -> = "+Math.Max(b,c));