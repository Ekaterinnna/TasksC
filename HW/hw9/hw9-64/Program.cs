// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int GetNumber(string text)
   {
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
   }

void Printing(int N)
{
    Console.Write($"{N}, ");
    if (N != 2) Printing(N-1);
    else Console.Write("1");
}

int N = GetNumber("Введите число N = ");
Printing(N);