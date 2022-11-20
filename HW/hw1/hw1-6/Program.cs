// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным.

Console.Write("Введите число ");
double n = Convert.ToDouble(Console.ReadLine());
double a = n % 2;

if (a == 0) 
    Console.WriteLine("да");
else Console.WriteLine("нет");
Console.ReadLine();