﻿// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число n = ");
int n = Convert.ToInt32(Console.ReadLine());

int a = (n % 100) / 10;
Console.WriteLine(a);