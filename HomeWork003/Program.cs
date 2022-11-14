//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число a: ");
double a = Convert.ToInt32(Console.ReadLine());
double b = 2;

if (a % b == 0)
{
   
   Console.WriteLine(+a+" -> да");
}
else
{
    Console.WriteLine(+a+" -> нет");
}
